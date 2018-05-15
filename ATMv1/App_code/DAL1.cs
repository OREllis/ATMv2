using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>

/// </summary>

public class DAL1
{

    public Dictionary<String, Manager> loadManagers()
    {
        Manager myManager;
        Dictionary<String, Manager> managersCollection = new Dictionary<String, Manager>();

        myManager = new Manager("111111", "Mickey", "Mouse", "1 Cathedral St", "07888888888", "a@b.com", "12345");
        managersCollection.Add(myManager.getId(), myManager);

        return managersCollection;
    }

    public Dictionary<String, Customer> loadCustomers()
    {
        Customer aCustomer;
        Account anAccount;
        Dictionary<String, Customer> customersCollection = new Dictionary<String, Customer>();

        aCustomer = new Customer("123456", "Minnie", "Mouse", "1 King St", "07999999999", "a@b.com");


        anAccount = new Account("11111111", "1111", 1000);
        aCustomer.addAccount(anAccount);

        anAccount = new Account("22222222", "2222", 2000);
        aCustomer.addAccount(anAccount);


        customersCollection.Add(aCustomer.getId(), aCustomer);
        return customersCollection;
    }


}