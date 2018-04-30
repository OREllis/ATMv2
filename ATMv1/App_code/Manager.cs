using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Manager
/// </summary>
public class Manager : Person
{
    private string mMachinePin;

    public string getMachinePin(string pMachinePin)
    {
        return mMachinePin;
    }

    public void setMachinePin(string pMachinePin)
    {
        mMachinePin = pMachinePin;
    }

    public Manager() : base()
    {
        mMachinePin = "";
    }

    public Manager(string idIn, string forenameIn, string surnameIn, string homeAddressIn, 
        string telNoIn, string emailIn, string machinePinIn) : 
        base(idIn, forenameIn, surnameIn, homeAddressIn, telNoIn, emailIn)
    {
        mMachinePin = machinePinIn;
    }
}