using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Person{

        // attribute/instance var
        private string _firstname, _lastname;
        private int _shoesize;

        // get/set OR properties
        public string FirstName {
            get { return _firstname;}
            set { _firstname = value; }
        }

        public string LastName {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public int ShoeSize {
            get { return _shoesize; }
            set { _shoesize = value; }
        }

        // default constructor
        public Person() {
            this._firstname = "";
            this._lastname = "";
            this._shoesize = 0;
        }

        //overload of constructor
        public Person(string firstname, string lastname, int shoesize) {
            this._firstname = firstname;
            this._lastname = lastname;
            this._shoesize = shoesize;
        }

        //public Person(int shoeSize) {
        //    this._firstname = "";
        //    this._lastname = "";
        //    this._shoesize = shoeSize;
        //}


        // other methods
        public string Talk() {
            return "My name is: " + FirstName + " " + LastName;
        }
    }
}
