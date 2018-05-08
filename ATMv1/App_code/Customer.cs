using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer : Person
{

    private Dictionary<int, Account> mAccounts;

    //get
    public Dictionary<int, Account> getMachinePin()
    {
        return mAccounts;
    }

    //set
    public void setMachinePin(Dictionary<int, Account> accountsIn)
    {
        mAccounts = accountsIn;
    }

    //default constructor
    public Customer() : base()
    {
        mAccounts = new Dictionary<int, Account>();
    }

    //override where all vars for this and the base class are assigned on creation
    public Customer(string idIn, string forenameIn, string surnameIn, string homeAddressIn,
        string telNoIn, string emailIn, Dictionary<int, Account> accountsIn) : 
        base(idIn, forenameIn, surnameIn, homeAddressIn, telNoIn, emailIn)
    {
        mAccounts = accountsIn;
    }


    //adds Account parameter to dictionary and generates a random 4-digit pin as its key
    public void addAccount(Account accountIn)
    {
        //possible lambda option
        //if (mAccounts.Where(x => x.Value.getAccountNumber() == (accountIn.getAccountNumber())) == null) {
        //    mAccounts.Add((mAccounts.Keys.Last()+1), accountIn);
        //}

        foreach (KeyValuePair<int, Account> i in mAccounts)
        {
            if (i.Value.getAccountNumber() == accountIn.getAccountNumber())
                throw new InvalidOperationException("Error, matching Account Numbers");
        }

        mAccounts.Add((mAccounts.Keys.Last() + 1), accountIn);
    }

    //checks if inputPin exists in the dictionary, if it does it returns true, otherwise, false
    public bool checkPin(int inputPin) {
        return (mAccounts.Where(x => x.Value.getPin().Equals(inputPin)) != null);
    }

    //returns the account where mPin = inputPin, returns null otherwise
    public Account getAccount(string inputPin) {
        return (Account)mAccounts.Where(x => x.Value.getPin().Equals(inputPin));
    }



}
