using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Bank
/// </summary>
public class Bank
{

    private string mATMId;
    private Dictionary<string, Manager> mBankManagers;
    private Dictionary<string, Customer> mCustomers;
    private int mCardsRetained, mFailedLogins, mTimesUsed;
    private decimal mExchangeRate, mTotalBalance, mWithdrawals;


    public string getATMId() {
        return mATMId;
    }

    public void setATMId(string ATMIdIn) {
        mATMId = ATMIdIn;
    }

    public Dictionary<string, Manager> getBankManagers() {
        return mBankManagers;
    }

    public Dictionary<string, Customer> getCustomers() {
        return mCustomers;
    }

    public int getCardsRetained() {
        return mCardsRetained;
    }

    public void setCardsRetained(int cardsRetainedIn) {
        mCardsRetained = cardsRetainedIn;
    }

    public int getFailedLogins() {
        return mFailedLogins;
    }

    public void setFailedLogins(int failedLoginsIn) {
        mFailedLogins = failedLoginsIn;
    }

    public int getTimesUsed() {
        return mTimesUsed;
    }

    public void setTimesUsed(int timesUsedIn) {
        mTimesUsed = timesUsedIn;
    }

    public decimal getExchangeRate() {
        return mExchangeRate;
    }

    public void setExchangeRate(decimal exchangeRateIn) {
        mExchangeRate = exchangeRateIn;
    }

    public decimal getTotalBalance() {
        return mTotalBalance;
    }

    public decimal getWithdrawals() {
        return mWithdrawals;
    }


    public Bank() {
        mATMId = "ABANK01";
        mBankManagers = new DAL1().loadManagers();
        mCustomers = new DAL1().loadCustomers();
        mExchangeRate = 1.12M;
        mTimesUsed = 0;
        mWithdrawals = 0;     
        mTotalBalance = 100000;
        mFailedLogins = 0;
        mCardsRetained = 0;
    }

    public bool withdraw(string loginIn, string inputPin, int amount) {
        try
        {
            //check if debit(amount) is true and the bank has the funds to withdraw
            if (mCustomers[loginIn].getAccount(inputPin).debit(amount) && mTotalBalance >= amount)
            {
                //adds amount to withdrawals & subtracts amount from total balance
                mWithdrawals += amount;
                mTotalBalance -= amount;
                return true;
            }

            //if debit returns false or bank doesn't have enough funds
            return false;
        }
        catch (KeyNotFoundException) {
            //returns false if either loginIn or inputPin aren't valid
            return false;
        }
    }

    public decimal getBalance(string loginIn, string inputPin) {
        return mCustomers[loginIn].getAccount(inputPin).getBalance();
    }

    public void addCustomer(Customer customerIn) {
        //check if customer exists in dictionary
        foreach (KeyValuePair<string, Customer> i in mCustomers) {
            if (customerIn == i.Value)
                return;
        }

        //add account if not
        mCustomers.Add((mCustomers.Keys.Last() +1).ToString(), customerIn);
    }

    public bool isValidManagerLogin(string manIdIn, string machinePinIn) {
        try {
            return (mBankManagers[manIdIn].getMachinePin() == machinePinIn);
        }
        catch (KeyNotFoundException) {
            return false;
        }
    }

    public bool isValidAccountLogin(string loginIn, string pinIn)
    {
        try{
            return (mCustomers[loginIn].checkPin(pinIn));
        }
        catch (KeyNotFoundException)
        {
            return false;
        }
    }


}