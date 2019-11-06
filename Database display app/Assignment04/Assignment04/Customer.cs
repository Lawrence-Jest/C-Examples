// Class Customer to create a Customer object
//
//Lawrence Jest-A00583216
//June 12, 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Customer
    {

        // Properties
        public string CustomerCode { get; private set; }

        public string CompanyName { get; private set; }

        public string Address { get; private set; }

        public string City { get; private set; }

        public string Province { get; private set; }

        public string PostalCode { get; private set; }

        public bool CreditHold { get; private set; }

        // Default Constructor
        public Customer() { }

        //Overloaded Constructor
        public Customer(string customerCode, string companyName, string address, string city,
                        string province, string postalCode, bool creditHold)
        {
            this.CustomerCode = customerCode;

            this.CompanyName = companyName;

            this.Address = address;

            this.City = city;

            this.Province = province;

            this.PostalCode = postalCode;

            this.CreditHold = creditHold;

        }




    }
}
