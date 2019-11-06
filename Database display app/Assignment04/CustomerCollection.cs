// Class CustomerCollection to create a list of customers from a database
//datatable
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
    class CustomerCollection
    {

        // Properties
        public DataTable DataTable { get; private set; }


        // Default constructor
        public CustomerCollection() { }


        // Overloaded constructor
        public CustomerCollection(DataTable dataTable)
        {
            this.DataTable = dataTable;
        }


        // Method to take a dataTable and create a customer objects and add
        //them to a list of customers and return the list of customers
        public List<Customer> createCustomerListFromDataTable(DataTable dataTable)
        {
            List<Customer> customers = new List<Customer>();


            foreach (DataRow row in dataTable.Rows)
            {
                bool success = false;

                bool value = false;

                //if CreditHold is null will set value to false
                success = Boolean.TryParse(row["CreditHold"].ToString(), out value);

                Customer customer = new Customer(row["CustomerCode"].ToString(),
                                                  row["CompanyName"].ToString(),
                                                  row["Address"].ToString(),
                                                  row["City"].ToString(),
                                                  row["Province"].ToString(),
                                                  row["PostalCode"].ToString(),
                                                  value);
                customers.Add(customer);
            }


            return customers;
        }


    }
}
