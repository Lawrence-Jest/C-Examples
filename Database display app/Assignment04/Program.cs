// Class Program to run the application
//
//Lawrence Jest-A00583216
//June 12, 2018

using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using Assignment04;

namespace Starter
{
    class Program
    {


        public static void Main()
        {
            // Create utility object
            Utility utility = new Utility();

            // Get user input
            int userChoice = utility.userInputForProvince();

            // Get sql string from user input
            string sqlString = utility.SqlStringChoice(userChoice);

            // Create new display object
            Display display = new Display();

            // Display the header from previous user input
            display.displayHeader(userChoice);

            // Get datatable obeject
            DataTable dt = DataBase.RunSQL(sqlString);

            // Create new customer collection object
            CustomerCollection customerCollection = new CustomerCollection();

            // Create new list of Customer object 
            List<Customer> customerList = customerCollection.createCustomerListFromDataTable(dt);

            // Display list of customer objects
            display.displayCustomerObjects(customerList);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press return to exit.");

            Console.ReadLine();

            
        }
    }
}
