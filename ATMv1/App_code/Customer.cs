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


    //checks if account number key exists, if not, adds the passed account
    public void addAccount(Account accountIn)
    {
        string accountNo = accountIn.getAccountNumber();
        if (!mAccounts.ContainsKey(accountIn.getAccountNumber()))
            mAccounts.Add(accountIn.getAccountNumber(), accountIn);
    }

    //checks if inputPin exists in the dictionary, if it does it returns true, otherwise, false
    public bool checkPin(string inputPin) {
        return (mAccounts.TakeWhile(x => x.Value.getPin().Equals(inputPin)) != null);
    }

    //returns the account where mPin = inputPin, returns null otherwise
    public Account getAccount(string inputPin) {
        return (Account)mAccounts.TakeWhile(x => x.Value.getPin().Equals(inputPin));
    }



}
