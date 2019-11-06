//class Contact to create a contact object
//
//Lawrence Jest-A00583216
//May 13, 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614Assign02
{
    class Contact
    {

        //properties
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Address { set; get; }
        public string City { set; get; }
        public string Province { set; get; }
        public string PostalCode { set; get; }

        //constructors
       public  Contact()
        {

        }

        public Contact(string firstName, string lastName, string address, 
            string city, string province, string postalCode )
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            Province = province;
            PostalCode = postalCode;

        }

        //overridden ToString method
        public string ToString(string firstName, string lastName)
        {           
            return string.Format("{0}, {1}", lastName, firstName) ;
        }



    }
}
