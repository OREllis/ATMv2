using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Customer : Person
    {
        private string _username, _password;

        // get/set for username & password
        public string Username { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }


        //consturctor calls super constructor
        public Customer() : base() {
            this._username = "";
            this._password = "";
        }

        //overload
        public Customer(string firstname, string lastname, int shoesize, 
            string username, string password) : base(firstname, lastname, shoesize) {
            this._username = username;
            this._password = password;
        }
    }
}
