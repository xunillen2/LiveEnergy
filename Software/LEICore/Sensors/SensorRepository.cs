using LEICore.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEICore.Sensors
{
    public class SensorRepository
    {
        /// <summary>
        /// Creates User object 
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>
        /// Returns "Sensor" object with populated Properties from sql reader.
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
        /// returns List<Sensor>
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
        /// returns User
        /// </returns>
        public Sensor GetSensor(int id) =>
            FetchSensor($"SELECT * FROM Sensors WHERE Id = {id} ");


        /// <summary>
        /// Fetchs Sensor with given sql string.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>
        /// Returns Teacher object if found, null if not.
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
