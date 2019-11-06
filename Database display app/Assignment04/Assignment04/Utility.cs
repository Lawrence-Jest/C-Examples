// Class Utility to hold methods for user input and and use that user input to 
// create a SQl statement
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
    class Utility
    {
        // Constants
        const string SELECTION_FORMAT = "{0,9}{1}";

        // Method to return an int pertaining to the users choice for provinces
        public int userInputForProvince()
        {
            int userChoice = 0;

            bool isConvertible = false;

            // User Choices
            Console.WriteLine("Select province filter:");

            Console.WriteLine(SELECTION_FORMAT, "", "1: AB");

            Console.WriteLine(SELECTION_FORMAT, "", "2: BC");

            Console.WriteLine(SELECTION_FORMAT, "", "3: ON");

            Console.WriteLine(SELECTION_FORMAT, "", "4: SK");

            Console.WriteLine(SELECTION_FORMAT, "", "5: ALL");

            // TryParse from string to int
            isConvertible = int.TryParse(Console.ReadLine(), out userChoice);

            return userChoice;
        }


        // Method to return a Sql statement string based on the users choice       
        public string SqlStringChoice(int userChoice)
        {
            string sqlString = "";

            switch (userChoice)
            {
                case 1:
                    sqlString = "SELECT * FROM Customer WHERE Province = 'AB' ORDER by CompanyName";
                    break;

                case 2:
                    sqlString = "SELECT * FROM Customer WHERE Province = 'BC' ORDER by CompanyName";
                    break;

                case 3:
                    sqlString = "SELECT * FROM Customer WHERE Province = 'ON' ORDER by CompanyName";
                    break;

                case 4:
                    sqlString = "SELECT * FROM Customer WHERE Province = 'SK' ORDER by CompanyName";
                    break;

                case 5:
                    sqlString = "SELECT * FROM Customer ORDER by CompanyName";
                    break;

                // Default selects All incase of user error or can be hidden
                //shortcut
                default:
                    sqlString = "SELECT * FROM Customer ORDER by CompanyName";
                    break;

            }

            return sqlString;
        }

    }
}
