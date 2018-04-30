using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer : Person
{

    private Dictionary<string, Account> mAccounts;

    //get
    public Dictionary<string, Account> getMachinePin()
    {
        return mAccounts;
    }

    //set
    public void setMachinePin(Dictionary<string, Account> accountsIn)
    {
        mAccounts = accountsIn;
    }

    //default constructor
    public Customer() : base()
    {
        mAccounts = new Dictionary<string, Account>();
    }

    //override where all vars for this and the base class are assigned on creation
    public Customer(string idIn, string forenameIn, string surnameIn, string homeAddressIn,
        string telNoIn, string emailIn, Dictionary<string, Account> accountsIn) : 
        base(idIn, forenameIn, surnameIn, homeAddressIn, telNoIn, emailIn)
    {
        mAccounts = accountsIn;
    }


    //adds Account parameter to dictionary and generates a random 4-digit pin as its key
    public void addAccount(Account accountIn)
    {
        if (mAccounts.Where(x => x.Value.getAccountNumber() ==
             (accountIn.getAccountNumber())) == null) {
            mAccounts.Add(new Random().Next(1111, 10000).ToString(), accountIn);
        } 
    }

    //checks if inputPin exists in the dictionary, if it does it returns true, otherwise, false
    public bool checkPin(string inputPin) {
        bool validPin = (mAccounts.Where(x => x.Value.getPin().Equals(inputPin)) != null) ? true : false;
        return validPin;
    }

    //returns the account where mPin = inputPin, returns null otherwise
    public Account getAccount(string inputPin) {
        return (Account)mAccounts.Where(x => x.Value.getPin().Equals(inputPin));
    }



}
