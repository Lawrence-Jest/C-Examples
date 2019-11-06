// Class Display to display results to Console
//
//Lawrence Jest-A00583216
//June 12, 2018

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Display
    {
        const string CUSTOMER_LISTING = "Customer listing for ";

        const string CUSTOMER_FORMAT = "{0,-37}{1,-15}{2,-4} {3,-8}{4,2}";

        const string HYPHEN_LINE = "-------------------------------------------" +
                                   "--------------------------";


        // Iterate through DataTable rows and columns to show data. 
        public void ShowOutput(DataTable dt)
        {
            if (dt == null)
            {
                Console.WriteLine("Empty dataset: Check your SQL.");

                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                    Console.Write(row[col].ToString() + ", ");

                Console.WriteLine();
            }
        }


        // Display header default set to all
        public void displayHeader(int userChoice)
        {
            // choose province from user input
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("{0}{1}", CUSTOMER_LISTING, "AB");
                    break;

                case 2:
                    Console.WriteLine("{0}{1}", CUSTOMER_LISTING, "BC");
                    break;

                case 3:
                    Console.WriteLine("{0}{1}", CUSTOMER_LISTING, "ON");
                    break;

                case 4:
                    Console.WriteLine("{0}{1}", CUSTOMER_LISTING, "SK");
                    break;

                case 5:
                    Console.WriteLine("{0}{1}", CUSTOMER_LISTING, "ALL");
                    break;

                default:
                    Console.WriteLine("{0}{1}", CUSTOMER_LISTING, "ALL");
                    break;
            }

            Console.WriteLine();

            Console.WriteLine(CUSTOMER_FORMAT, "CompanyName", "City", "Prov", "Postal", "Hold");

            Console.WriteLine(HYPHEN_LINE);

        }


        // Display customer objects
        public void displayCustomerObjects(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                string falseToCharN = "";

                // Convert strings false to N, true to Y 
                if (customer.CreditHold == false)
                {
                    falseToCharN = "N";
                }
                else
                {
                    falseToCharN = "Y";
                }

                // Display customer
                Console.WriteLine(CUSTOMER_FORMAT,
                                  customer.CompanyName,
                                  customer.City,
                                  customer.Province,
                                  customer.PostalCode,
                                  falseToCharN);
            }
        }
    }
}
