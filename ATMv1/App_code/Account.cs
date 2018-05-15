using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Account
/// </summary>
public class Account
{
    private string mAccountNumber, mPin;
    private decimal mBalance;


    //get accountNumber
    public string getAccountNumber() {
        return mAccountNumber;
    }

    //set accountNumber
    public void setAccountNumber(string accountNumberIn) {
        mAccountNumber = accountNumberIn;
    }

    //get pin
    public string getPin() {
        return mPin;
    }

    //set pin
    public void setPin(string pinIn) {
        mPin = pinIn;
    }

    //get balance
    public decimal getBalance() {
        return mBalance;
    }

    //set balance
    public void setBalance(decimal balanceIn) {
        mBalance = balanceIn;
    }


    //default constructor
    public Account() {
        mAccountNumber = mPin = "";
        mBalance = 0;
    }

    //setter constructor
    public Account(string accountNumberIn, string pinIn, decimal balanceIn) {
        mAccountNumber = accountNumberIn;
        mPin = pinIn;
        mBalance = balanceIn;
    }


    //credits receiver account with param value
    public void credit(decimal amount) {
        mBalance += amount;
    }

    //subtracts param amount from balance, returns true if valid, false if not
    public bool debit(decimal amount) {
        if (mBalance >= amount) {
            mBalance -= amount;
            return true;
        }

        return false;
    }
}