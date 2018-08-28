using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Jan_Prototype
{
    class User
    {
        private string username;
        private string password;
        public bool loggedIn;

        public User(string username, string password, bool loggedIn)
        {
            this.username = username;
            this.password = password;
            this.loggedIn = loggedIn;
        }

        public string getUsername() {
            return this.username;
        }

        public string getPassword()
        {
            return this.password;
        }

        public bool isLoggedIn()
        {
            return this.loggedIn;
        }

    }
}
