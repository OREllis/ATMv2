using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Person
/// </summary>
public class Person
{
    private string id, forename, surname, homeAddress, telNo, email;

    public Person()
    {
        //initialise vars
        id = forename = surname = homeAddress = telNo = email = "";
    }

    public Person(string idIn, string forenameIn, string surnameIn, string homeAddressIn,
        string telNoIn, string emailIn)
    {
        id = idIn;
        forename = forenameIn;
        surname = surnameIn;
        homeAddress = homeAddressIn;
        telNo = telNoIn;
        email = emailIn;
    }
}