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
    private double mBalance;
    private int mSwallowed;

    public string getAccountNumber() {
        return mAccountNumber;
    }

    public void setAccountNumber(string accountNumberIn) {
        mAccountNumber = accountNumberIn;
    }

    public string getPin() {
        return mPin;
    }

    public void setPin(string pinIn) {
        mPin = pinIn;
    }

    public double getBalance() {
        return mBalance;
    }

    public void setBalance(double balanceIn) {
        mBalance = balanceIn;
    }

    public int getSwallowed() {
        return mSwallowed;
    }

    public void setSwallowed(int swallowedIn) {
        mSwallowed = swallowedIn;
    }

    public Account()
    {
        mAccountNumber = mPin = "";
        mBalance = 0;
        mSwallowed = 0;
    }

    public Account(string accountNumberIn, string pinIn, double balanceIn, int swallowedIn) {
        mAccountNumber = accountNumberIn;
        mPin = pinIn;
        mBalance = balanceIn;
        mSwallowed = swallowedIn;
    }
}