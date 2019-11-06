//class Program to collect data for contact object and poplulate an array
//with that data
//
//Lawrence Jest-A00583216
//May 13, 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614Assign02
{
    class Program
    {
        //constants
        const string HEADER_TITLE = "Contact Information";
        const string HYPHEN_LINE = "------------------------------";
        const string USER_INPUT_FORMAT = "{0, -13}";       
        const int CONTACT_ARRAY_SIZE = 3;


        static void Main(string[] args)
        {            

            //variables
            string firstName;
            string lastName;
            string address;
            string city;
            string province;
            string postalCode;

            
            //header
            Console.WriteLine("{0}", HEADER_TITLE );
            Console.WriteLine("{0}", HYPHEN_LINE);

            //user input
            Console.Write(USER_INPUT_FORMAT, "Firstname: ");
            firstName = Console.ReadLine();

            Console.Write(USER_INPUT_FORMAT, "Lastname: ");
            lastName = Console.ReadLine();

            Console.Write(USER_INPUT_FORMAT, "Address: ");
            address = Console.ReadLine();

            Console.Write(USER_INPUT_FORMAT, "City: ");
            city = Console.ReadLine();

            Console.Write(USER_INPUT_FORMAT, "Province: ");
            province = Console.ReadLine();

            Console.Write(USER_INPUT_FORMAT, "Postal Code: ");
            postalCode = Console.ReadLine();

            
            //populate contact object with default constructor
            Contact contact1 = new Contact();
            contact1.FirstName = firstName;
            contact1.LastName = lastName;
            contact1.Address = address;
            contact1.City = city;
            contact1.Province = province;
            contact1.PostalCode = postalCode;

            //populate contact object with overloaded constructor
            Contact contact2 = new Contact(firstName, lastName, address, city,
                                           province, postalCode);

            //populate contact object with object initializer syntax
            Contact contact3 = new Contact { FirstName = firstName,
                                             LastName = lastName,
                                             Address = address,
                                             City = city,
                                             Province = province,
                                             PostalCode = postalCode};

            //populate contact array
            Contact[] contactArray = new Contact[CONTACT_ARRAY_SIZE];
            contactArray[0] = contact1;
            contactArray[1] = contact2;
            contactArray[2] = contact3;

          

            //contact output
            Utility utility1 = new Utility();

            utility1.display(contactArray);

            //pause and exit program
            Console.WriteLine("Press 'return' to exit.");
            Console.ReadLine();
        }
    }
}
