using LEICore.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEICore.Sensors
{
    /// <summary>
    /// Class for managing Sensor database.
    /// It Contains functions for fetching sensors from db.
    /// </summary>
    public class SensorRepository
    {
        /// <summary>
        /// Creates Sensor object 
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>
        /// Returns "Sensor" object with populated Properties from SqlDataReader.
        /// </returns>
        private static Sensor CreateObject(SqlDataReader reader)
        {
            Sensor sensor = new Sensor();

            sensor.Id = Convert.ToUInt32(reader["Id"].ToString());
            sensor.Name = reader["Name"].ToString();

            return sensor;
        }


        /// <summary>
        /// Gets All Sensors from databases
        /// </summary>
        /// <returns>
        /// Returns List<Sensor>
        /// </returns>
        public List<Sensor> GetSensors()
        {
            List<Sensor> slist = new List<Sensor>();
            SqlDataReader reader;

            DBReader.OpenConnection();
            reader = DBReader.GetDataReader("SELECT * FROM Sensors");
            while (reader.Read())
            {
                Sensor sensor = CreateObject(reader);
                slist.Add(sensor);
            }

            reader.Close();
            DBReader.CloseConnection();

            return slist;
        }

        /// <summary>
        /// Gets Sensor with specified id
        /// </summary>
        /// <returns>
        /// Returns Sensor object if id exists,
        /// if not, it returns null.
        /// </returns>
        public Sensor GetSensor(int id) =>
            FetchSensor($"SELECT * FROM Sensors WHERE Id = {id} ");


        /// <summary>
        /// Fetchs Sensor from database that matches given sql query
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>
        /// Returns Sensor object if found, null if not.
        /// </returns>
        public Sensor FetchSensor(string sql)
        {
            Sensor sensor = null;
            SqlDataReader reader;

            DBReader.OpenConnection();
            reader = DBReader.GetDataReader(sql);
            while (reader.Read())
            {
                sensor = CreateObject(reader);
            }

            reader.Close();
            DBReader.CloseConnection();

            return sensor;
        }
    }
}
