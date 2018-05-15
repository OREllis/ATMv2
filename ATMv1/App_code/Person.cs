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


    // get/set vars
    public string getId() {
        return id;
    }

    public void setId(string idIn) {
        id = idIn;
    }

    public string getForename() {
        return forename;
    }

    public void setForename(string forenameIn) {
        forename = forenameIn;
    }

    public string getSurname() {
        return surname;
    }

    public void setSurname(string surnameIn) {
        surname = surnameIn;
    }

    public string getHomeAddress() {
        return homeAddress;
    }

    public void setHomeAddress(string homeAddressIn) {
        homeAddress = homeAddressIn;
    }

    public string getTelNo() {
        return telNo;
    }

    public void setTelNo(string telNoIn) {
        telNo = telNoIn;
    }

    public string getEmail() {
        return email;
    }

    public void setEmail(string emailIn) {
        email = emailIn;
    }


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