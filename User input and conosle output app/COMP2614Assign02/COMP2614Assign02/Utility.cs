//class Utility to display to console Contact class objects
//
//Lawrence Jest-A00583216
//May 13, 2018


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614Assign02
{
    class Utility
    {
        //constants
        const string HEADER_TITLE = "Contacts";
        const string HYPHEN_LINE = "------------------------------";


        //display method
        public void display(Contact[] contactArray)
        {

            //contact list header
            Console.WriteLine();
            Console.WriteLine(HEADER_TITLE);
            Console.WriteLine(HYPHEN_LINE);

            //display contact information with Canadian Postal Standard
            for (int index =0; index < contactArray.Length; ++index)
            {
                Console.WriteLine("{0} {1}", contactArray[index].FirstName, 
                                             contactArray[index].LastName );

                Console.WriteLine("{0}", contactArray[index].Address);

                Console.WriteLine("{0} {1}  {2}", contactArray[index].City, 
                                                  contactArray[index].Province, 
                                                  contactArray[index].PostalCode);
                Console.WriteLine();
                Console.WriteLine();
            }


        }


    }
}
