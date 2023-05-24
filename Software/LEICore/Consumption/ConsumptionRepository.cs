using LEICore.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LEICore.Consumption.ConsumptionData;

namespace LEICore.Consumption
{
    /// <summary>
    /// Class for managing Consumption history of Objects.
    /// It Contains functions for Fetching and Inserting 
    /// Consumption data from Senzors and Objects to table
    /// "Consumptions"
    /// </summary>
    public class ConsumptionRepository
    {

        /// <summary>
        /// Creates ConsumptionData object 
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>
        /// Returns "ConsumptionData" object with populated Properties from SqlDataReader.
        /// </returns>
        private static ConsumptionData CreateObject(SqlDataReader reader, bool loadObject)
        {
            ConsumptionData consumptionData = new ConsumptionData();
            ObjectRepository objrepository = new ObjectRepository(); 

            consumptionData.Id = Convert.ToInt32(reader["Id"].ToString());
            consumptionData.ConsumptionType = (consumptionType)Convert.ToInt32(reader["ConsumptionType"].ToString());
            consumptionData.ConsumptionValue = float.Parse(reader["ConsumptionValue"].ToString(), CultureInfo.InvariantCulture.NumberFormat);
            if (loadObject)
                consumptionData.Object = objrepository.GetObject(Convert.ToInt32(reader["ObjectID"].ToString()));
            else
                consumptionData.Object = new LEICore.Objects.Object { Id = Convert.ToInt32(reader["ObjectID"].ToString())};
            consumptionData.Date = DateTime.Parse(reader["Date"].ToString());

            return consumptionData;
        }



        /// <summary>
        /// Gets All consumption data from all objects in table "Consumptions".
        /// If loadObject is true, Propertie Object in ConsumptionData will be populated
        /// with all Objec data. If its false, only Id Propertie of class Object will be populated.
        /// </summary>
        /// <param name="loadObject"></param>
        /// <returns>
        /// List<ConsumptionData>
        /// </returns>
        public List<ConsumptionData> GetConsumptionsAll(bool loadObject) =>
            GetConsumptions($"SELECT * FROM Consumptions",
                loadObject);
        /// <summary>
        /// Gets consumption data from object specified by object_id from table "Consumptions".
        /// If loadObject is true, Propertie Object in ConsumptionData will be populated
        /// with all Objec data. If its false, only Id Propertie of class Object will be populated.
        /// </summary>
        /// <param name="object_id"></param>
        /// <param name="loadObject"></param>
        /// <returns>
        /// List<ConsumptionData>
        /// </returns>
        public List<ConsumptionData> GetConsumptionsByObject(int object_id, bool loadObject) =>
            GetConsumptions($"SELECT * FROM Consumptions WHERE ObjectID = {object_id}",
                loadObject);
        /// <summary>
        /// Gets consumption data from object specified by object_id from table "Consumptions",
        /// and match Conumption by given type specified by consumptiontype.
        /// If loadObject is true, Propertie Object in ConsumptionData will be populated
        /// with all Objec data. If its false, only Id Propertie of class Object will be populated.
        /// </summary>
        /// <param name="object_id"></param>
        /// <param name="consumptiontype"></param>
        /// <param name="loadObject"></param>
        /// <returns>
        /// List<ConsumptionData>
        /// </returns>
        public List<ConsumptionData> GetConsumptionsByObjAndType(int object_id, consumptionType consumptiontype, bool loadObject) =>
            GetConsumptions($"SELECT * FROM Consumptions WHERE ObjectID = {object_id} AND ConsumptionType = {(int)consumptiontype}",
                loadObject);

        public void InsertConsumption(ConsumptionData consumptionData)
        {
            string sql = $"INSERT INTO Consumptions (Id, ConsumptionType, ConsumptionValue, Date, ObjectID) VALUES ({consumptionData.Id}, {(int)consumptionData.ConsumptionType}, '{consumptionData.ConsumptionValue.ToString().Replace(",", ".")}' , '{consumptionData.Date.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}', {consumptionData.Object.Id})";


            DBReader.OpenConnection();
            DBReader.ExecuteCommand(sql);
            DBReader.CloseConnection();
        }

        public ConsumptionData GetConsumptionMaxId() =>
            FetchObject($"SELECT * FROM Consumptions WHERE Id = (SELECT MAX(Id) FROM Consumptions)", true);


        /// <summary>
        /// Gets all ConsumptionData from database that matches sql query.
        /// If loadObject is true, Propertie Object in ConsumptionData will be populated
        /// with all Objec data. If its false, only Id Propertie of class Object will be populated.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="loadObject"></param>
        /// <returns>
        /// List<ConsumptionData>
        /// </returns>
        private List<ConsumptionData> GetConsumptions(string sql, bool loadObject)
        {
            List<ConsumptionData> clist = new List<ConsumptionData>();
            SqlDataReader reader;

            DBReader.OpenConnection();
            reader = DBReader.GetDataReader(sql);
            while (reader.Read())
            {
                ConsumptionData consumption = CreateObject(reader, loadObject);
                clist.Add(consumption);
            }

            reader.Close();
            DBReader.CloseConnection();

            return clist;
        }



        /// <summary>
        /// Gets ConsumptionData from database that matches sql query.
        /// If loadObject is true, Propertie Object in ConsumptionData will be populated
        /// with all Objec data. If its false, only Id Propertie of class Object will be populated.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="loadObject"></param>
        /// <returns>
        /// ConsumptionData
        /// null if object does not exist in db.
        /// </returns>
        private ConsumptionData FetchObject(string sql, bool loadObject)
        {
            ConsumptionData cdata = null;
            SqlDataReader reader;

            DBReader.OpenConnection();
            reader = DBReader.GetDataReader(sql);
            while (reader.Read())
            {
                cdata = CreateObject(reader, loadObject);
            }

            reader.Close();
            DBReader.CloseConnection();

            return cdata;
        }
    }
}
