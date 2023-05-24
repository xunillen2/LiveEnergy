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
    public class ConsumptionRepository
    {

        /// <summary>
        /// Creates User object 
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>
        /// Returns "Sensor" object with populated Properties from sql reader.
        /// </returns>
        private static ConsumptionData CreateObject(SqlDataReader reader)
        {
            ConsumptionData consumptionData = new ConsumptionData();
            ObjectRepository objrepository = new ObjectRepository(); 

            consumptionData.Id = Convert.ToInt32(reader["Id"].ToString());
            consumptionData.ConsumptionType = (consumptionType)Convert.ToInt32(reader["ConsumptionType"].ToString());
            consumptionData.ConsumptionValue = float.Parse(reader["ConsumptionValue"].ToString(), CultureInfo.InvariantCulture.NumberFormat);
            consumptionData.Object = objrepository.GetObject(Convert.ToInt32(reader["ObjectID"].ToString()));
            consumptionData.Date = DateTime.Parse(reader["Date"].ToString());

            return consumptionData;
        }


        /// <summary>
        /// Gets Sensor with specified id
        /// </summary>
        /// <returns>
        /// returns User
        /// </returns>
        public List<ConsumptionData> GetConsumptionsAll() =>
            GetConsumptions($"SELECT * FROM Consumptions");

        /// <summary>
        /// Gets Sensor with specified id
        /// </summary>
        /// <returns>
        /// returns User
        /// </returns>
        public List<ConsumptionData> GetConsumptionsByObject(int object_id) =>
            GetConsumptions($"SELECT * FROM Consumptions WHERE ObjectID = {object_id}");

        public void InsertConsumption(ConsumptionData consumptionData)
        {
            string sql = $"INSERT INTO Consumptions (Id, ConsumptionType, ConsumptionValue, Date, ObjectID) VALUES ({consumptionData.Id}, {(int)consumptionData.ConsumptionType}, '{consumptionData.ConsumptionValue.ToString().Replace(",", ".")}' , '{consumptionData.Date.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}', {consumptionData.Object.Id})";


            DBReader.OpenConnection();
            DBReader.ExecuteCommand(sql);
            DBReader.CloseConnection();
        }


        /// <summary>
        /// Gets All Sensors from databases
        /// </summary>
        /// <returns>
        /// returns List<Sensor>
        /// </returns>
        private List<ConsumptionData> GetConsumptions(string sql)
        {
            List<ConsumptionData> clist = new List<ConsumptionData>();
            SqlDataReader reader;

            DBReader.OpenConnection();
            reader = DBReader.GetDataReader(sql);
            while (reader.Read())
            {
                ConsumptionData consumption = CreateObject(reader);
                clist.Add(consumption);
            }

            reader.Close();
            DBReader.CloseConnection();

            return clist;
        }



        /// <summary>
        /// Fetchs Sensor with given sql string.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>
        /// Returns Teacher object if found, null if not.
        /// </returns>
        private ConsumptionData FetchObject(string sql)
        {
            ConsumptionData cdata = null;
            SqlDataReader reader;

            DBReader.OpenConnection();
            reader = DBReader.GetDataReader(sql);
            while (reader.Read())
            {
                cdata = CreateObject(reader);
            }

            reader.Close();
            DBReader.CloseConnection();

            return cdata;
        }
    }
}
