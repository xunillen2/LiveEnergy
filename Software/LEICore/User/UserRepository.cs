using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEICore.Users
{
    public class UserRepository
    {

        /// <summary>
        /// Create User object 
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>
        /// Returns "User" object with populated Properties from sql reader.
        /// </returns>
        private static User CreateObject(SqlDataReader reader)
        {

            User user = new User();

            user.Id = Convert.ToInt32(reader["Id"].ToString());
            user.FirstName = reader["FirstName"].ToString();
            user.LastName = reader["LastName"].ToString();
            user.Email = reader["Email"].ToString();
            user.Username = reader["Username"].ToString();
            user.Password = reader["Password"].ToString();

            return user;
        }


        /// <summary>
        /// Gets All Users from databases
        /// </summary>
        /// <returns>
        /// returns List<User>
        /// </returns>
        public List<User> GetUsers()
        {
            List<User> ulist = new List<User>();
            SqlDataReader reader;

            DBReader.OpenConnection();
            reader = DBReader.GetDataReader("SELECT * FROM Users");
            while (reader.Read()) {
                User usr = CreateObject(reader);
                ulist.Add(usr);
            }

            reader.Close();
            DBReader.CloseConnection();

            return ulist;
        }

        /// <summary>
        /// Gets user with specified id
        /// </summary>
        /// <returns>
        /// returns User
        /// </returns>
        public User GetUser(int id) =>
            FetchUser($"SELECT * FROM Users WHERE Id = {id} ");

        /// <summary>
        /// Gets user with specified email
        /// </summary>
        /// <returns>
        /// returns User
        /// </returns>
        public User GetUser(string username) =>
            FetchUser($"SELECT * FROM Users WHERE Username = '{username}' ");


        /// <summary>
        /// Fetchs Teacher with given sql string.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>
        /// Returns Teacher object if found, null if not.
        /// </returns>
        public User FetchUser(string sql)
        {
            User user = null;
            SqlDataReader reader;

            DBReader.OpenConnection();
            reader = DBReader.GetDataReader(sql);
            while (reader.Read())
            {
                user = CreateObject(reader);
            }

            reader.Close();
            DBReader.CloseConnection();

            return user;
        }
    }
}
