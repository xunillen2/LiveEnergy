using LEICore.Consumption;
using LEICore.Sensors;
using LEICore.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;

namespace LEICore.Objects
{
    /// <summary>
    /// Class for managing Object database.
    /// It Contains functions for Fetching, Updating and Deleting Objects
    /// From database
    /// </summary>
    public class ObjectRepository
    {        
        
        /// <summary>
        /// Creates "Object" object 
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>
        /// "Object" object with populated Properties from SqlDataReader.
        /// </returns>
        private static Object CreateObject(SqlDataReader reader)
        {
            SensorRepository sensorRepository = new SensorRepository();
            UserRepository userRepository = new UserRepository();

            Object @object = new Object();

            @object.Id = Convert.ToInt32(reader["Id"].ToString());
            @object.Name = reader["Name"].ToString();
            @object.City = reader["City"].ToString();
            @object.Street = reader["Street"].ToString();
            @object.ObjectType = (objectType) Convert.ToInt32(reader["ObjectType"].ToString());
            @object.PredictedConsumption = Convert.ToInt32(reader["PredictedConsumption"].ToString());
            @object.Sensor = sensorRepository.GetSensor(Convert.ToInt32(reader["SensorID"].ToString()));
            @object.User = userRepository.GetUser(Convert.ToInt32(reader["UserID"].ToString()));
            
            return @object;
        }


        /// <summary>
        /// Gets all object that user specified with user_id has access to.
        /// </summary>
        /// <returns>
        /// List<Object>
        /// </returns>
        public List<Object> GetObjects(int user_id) =>
            GetObjects($"SELECT * FROM Objects WHERE UserID = {user_id} ");

        /// <summary>
        /// Gets all objects avilable in "Objects" table
        /// </summary>
        /// <returns>
        /// List<Object>
        /// </returns>
        public List<Object> GetObjects() =>
            GetObjects($"SELECT * FROM Objects");

        /// <summary>
        /// Gets Object with specified id
        /// </summary>
        /// <returns>
        /// Object
        /// null if object with given id does not exist.
        /// </returns>
        public Object GetObject(int id) =>
            FetchObject($"SELECT * FROM Objects WHERE Id = {id} ");

        /// <summary>
        /// Gets current maximum id from all Objects in "Objects" table.
        /// </summary>
        /// <returns>
        /// Object
        /// null if object does not exist.
        /// </returns>
        public Object GetObjectMaxId() =>
            FetchObject($"SELECT * FROM Objects WHERE Id = (SELECT MAX(Id) FROM Objects) ");

        /// <summary>
        /// Inserts given Object in "Objects" table.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        /// Updated row count on success (>=0)
        /// 0 if failed
        /// </returns>
        public int InsertObject(LEICore.Objects.Object obj)
        {
            int result;
            string sql = $"INSERT INTO Objects (Id, Name, City, Street, ObjectType, SensorID, UserID, PredictedConsumption) VALUES ({obj.Id}, '{obj.Name}', '{obj.City}' , '{obj.Street}', {(int)obj.ObjectType}, {obj.Sensor.Id}, {obj.User.Id}, {obj.PredictedConsumption})";


            DBReader.OpenConnection();
            result = DBReader.ExecuteCommand(sql);
            DBReader.CloseConnection();

            return result;
        }

        /// <summary>
        /// Updates Object in table "Objects" based on id given in obj parameter,
        /// and other properties given in obj parameter
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        /// Updated row count on success (>=0)
        /// 0 if failed
        /// </returns>
        public int UpdateObject(LEICore.Objects.Object obj)
        {
            int result;
            string sql = $"UPDATE Objects SET Name = '{obj.Name}', City = '{obj.City}', Street = '{obj.Street}', ObjectType = {(int)obj.ObjectType}, SensorID = {obj.Sensor.Id}, UserID = {obj.User.Id}, PredictedConsumption = {obj.PredictedConsumption} WHERE Id = {obj.Id}";


            DBReader.OpenConnection();
            result = DBReader.ExecuteCommand(sql);
            DBReader.CloseConnection();

            return result;
        }

        /// <summary>
        /// Drops Object with specified id from table "Objects".
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Updated row count on success (>=0)
        /// 0 if failed
        /// </returns>
        public int DropObject(int id)
        {
            int statuscode;
            string sql = $"DELETE FROM Objects WHERE Id = {id}";
            
            DBReader.OpenConnection();
            statuscode = DBReader.ExecuteCommand(sql);
            DBReader.CloseConnection();

            return statuscode;
        }

        /// <summary>
        /// Fetchs Objects with given sql string.
        /// </summary>
        /// <returns>
        /// returns List<Object>
        /// </returns>
        public List<Object> GetObjects(string sql)
        {
            List<Object> olist = new List<Object>();
            SqlDataReader reader;

            DBReader.OpenConnection();
            reader = DBReader.GetDataReader(sql);
            while (reader.Read())
            {
                Object sensor = CreateObject(reader);
                olist.Add(sensor);
            }

            reader.Close();
            DBReader.CloseConnection();

            return olist;
        }


        /// <summary>
        /// Fetchs Object with given sql string.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>
        /// Returns "Object" object if found, null if not.
        /// </returns>
        public Object FetchObject(string sql)
        {
            Object @object = null;
            SqlDataReader reader;
            DBReader.OpenConnection();
            reader = DBReader.GetDataReader(sql);
            while (reader.Read())
            {
                @object = CreateObject(reader);
            }
            reader.Close();
            DBReader.CloseConnection();
            return @object;
        }

    }
}
