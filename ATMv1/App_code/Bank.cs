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
    private Dictionary<int, Manager> mBankManagers;
    private Dictionary<int, Customer> mCustomers;
    private int mCardsRetained, mFailedLogins, mTimesUsed;
    private decimal mExchangeRate, mTotalBalance, mWithdrawals;


    public string getATMId() {
        return mATMId;
    }

    public void setATMId(string ATMIdIn)
    {
        mATMId = ATMIdIn;
    }

    public Dictionary<int, Manager> getBankManagers() {
        return mBankManagers;
    }

    public Dictionary<int, Customer> getCustomers() {
        return mCustomers;
    }

    public int getCardsRetained() {
        return mCardsRetained;
    }

    public void setCardsRetained(int cardsRetainedIn)
    {
        mCardsRetained = cardsRetainedIn;
    }

    public int getFailedLogins()
    {
        return mFailedLogins;
    }

    public void setFailedLogins(int failedLoginsIn)
    {
        mFailedLogins = failedLoginsIn;
    }

    public int getTimesUsed()
    {
        return mTimesUsed;
    }

    public void setTimesUsed(int timesUsedIn)
    {
        mTimesUsed = timesUsedIn;
    }

    public decimal getExchangeRate()
    {
        return mExchangeRate;
    }

    public void setExchangeRate(decimal exchangeRateIn)
    {
        mExchangeRate = exchangeRateIn;
    }

    public decimal getTotalBalance() {
        return mTotalBalance;
    }

    public decimal getWithdrawals() {
        return mWithdrawals;
    }


    public Bank()
    {
        mATMId = "ABANK01";
        mBankManagers = loadManagers();
        mCustomers = new Dictionary<int, Customer>();
        mExchangeRate = 1.12M;
        mTimesUsed = 0;
        mWithdrawals = 0;     
        mTotalBalance = 100000;
        mFailedLogins = 0;
        mCardsRetained = 0;
    }

    public bool withdraw(int loginIn, string inputPin, int amount) {
        try
        {
            if (mCustomers[loginIn].getAccount(inputPin).debit(amount))
            {
                mWithdrawals += amount;
                mTotalBalance -= amount;
                return true;
            }
        }
        catch (KeyNotFoundException) {
            return false;
        }

        return false;
    }

    public decimal getBalance(int loginIn, string inputPin)
    {
        return mCustomers[loginIn].getAccount(inputPin).getBalance();
    }

    public void addCustomer(Customer customerIn) {
        if (mCustomers.Where(x => x.Value == customerIn) == null)
            mCustomers.Add(mCustomers.Keys.Last() +1, customerIn);
    }

    public bool isValidManagerLogin(int manIdIn, string machinePinIn) {
        try {
            return (mBankManagers[manIdIn].getMachinePin() == machinePinIn);
        }
        catch (KeyNotFoundException) {
            return false;
        }
    }

    public bool isValidAccountLogin(int loginIn, int pinIn)
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