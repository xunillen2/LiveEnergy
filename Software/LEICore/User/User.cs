using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEICore.Users
{
    /// <summary>
    /// Specifies User class. This Class contains all user information
    /// and user roles.
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        internal roleType RoleType { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        /// <summary>
        /// Returns protecte RoleType Propertie
        /// </summary>
        /// <returns></returns>
        public roleType GetRole() { 
            return RoleType;
        }

        public bool IsAdmin() { 
            if (RoleType == roleType.Admin) return true;
            return false;
        }

        public enum roleType { 
            Admin,
            ObjectManager,
            LandLord
        }

    }
}
