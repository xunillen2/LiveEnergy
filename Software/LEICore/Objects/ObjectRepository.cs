using LEICore.Consumption;
using LEICore.Sensors;
using LEICore.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LEICore.Objects
{
    public class ObjectRepository
    {        
        
        /// <summary>
        /// Creates User object 
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>
        /// Returns "Sensor" object with populated Properties from sql reader.
        /// </returns>
        private static Object CreateObject(SqlDataReader reader)
        {
            SensorRepository sensorRepository = new SensorRepository();
            UserRepository userRepository = new UserRepository();

            Object @object = new Object();

            @object.Id = Convert.ToInt32(reader["Id"].ToString());
            @object.Name = reader["Name"].ToString();
            @object.City = reader["City"].ToString();
            @object.ObjectType = (objectType) Convert.ToInt32(reader["ObjectType"].ToString());
            @object.PredictedConsumption = Convert.ToInt32(reader["PredictedConsumption"].ToString());
            @object.Sensor = sensorRepository.GetSensor(Convert.ToInt32(reader["SensorID"].ToString()));
            @object.User = userRepository.GetUser(Convert.ToInt32(reader["UserID"].ToString()));

            return @object;
        }


        /// <summary>
        /// Gets All Sensors from databases
        /// </summary>
        /// <returns>
        /// returns List<Sensor>
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
        /// Gets Sensor with specified id
        /// </summary>
        /// <returns>
        /// returns User
        /// </returns>
        public List<Object> GetObjects(int user_id) =>
            GetObjects($"SELECT * FROM Objects WHERE UserID = {user_id} ");

        /// <summary>
        /// Gets Sensor with specified id
        /// </summary>
        /// <returns>
        /// returns User
        /// </returns>
        public List<Object> GetObjects() =>
            GetObjects($"SELECT * FROM Objects");

        /// <summary>
        /// Gets Sensor with specified id
        /// </summary>
        /// <returns>
        /// returns User
        /// </returns>
        public Object GetObject(int id) =>
            FetchObject($"SELECT * FROM Objects WHERE Id = {id} ");

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
        /// Fetchs Sensor with given sql string.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>
        /// Returns Teacher object if found, null if not.
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
