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
        public int Admin { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public bool IsAdmin() { 
            if (Admin <= 0) return false;
            return true;
        }

    }
}
