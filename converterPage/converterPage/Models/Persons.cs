using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace converterPage.Models
{
    public class Persons
    {

        private Dictionary<string, string> userDetails = new Dictionary<string, string>();

        Persons(string filePath){
            try {
                fileToPersons(filePath);
            }
            catch {
                return;
            }
        }

        public void addDetails(string userName, string password) {
            //don't add if username is same
            if (userDetails.ContainsKey(userName))
                return;
            
            //add username & password to dictionary
            userDetails.Add(userName, password);
        }

        public string getPass(string username) {
            //return password if valid username is entered
            if (userDetails.ContainsKey(username))
                return userDetails[username];

            //otherwise, return null
            return null;
        }

        //spaghetti WOOOOOOO!
        public Dictionary<string, string> getAll() {
            return userDetails;
        }

        //use for SQL? file that stores details? I don't know what I'm doing.
        public void fileToPersons(string filePath) {
            
                    
            return;
        }

        public void personsToFile() {
            //TODO: create file / SQL database to store user details
        }

        
       
    }
}