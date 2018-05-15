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
        string telNoIn, string emailIn) : 
        base(idIn, forenameIn, surnameIn, homeAddressIn, telNoIn, emailIn)
    {
        mAccounts = new Dictionary<string, Account>();
    }


    //adds Account parameter to dictionary and generates a random 4-digit pin as its key
    public void addAccount(Account accountIn)
    {
        //possible lambda option
        //if (mAccounts.Where(x => x.Value.getAccountNumber() == (accountIn.getAccountNumber())) == null) {
        //    mAccounts.Add((mAccounts.Keys.Last()+1), accountIn);
        //}

        foreach (KeyValuePair<string, Account> i in mAccounts)
        {
            if (i.Value.getAccountNumber() == accountIn.getAccountNumber())
                return;
        }

        mAccounts.Add((mAccounts.Keys.Last() + 1).ToString(), accountIn);
    }

    //checks if inputPin exists in the dictionary, if it does it returns true, otherwise, false
    public bool checkPin(string inputPin) {
        return (mAccounts.Where(x => x.Value.getPin().Equals(inputPin)) != null);
    }

    //returns the account where mPin = inputPin, returns null otherwise
    public Account getAccount(string inputPin) {
        return (Account)mAccounts.Where(x => x.Value.getPin().Equals(inputPin));
    }



}
