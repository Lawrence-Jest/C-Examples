// Class DAteValidator to validate a passed strings of year,month,day
// and return a bool if a succesful datetime object is created.
//
// Lawrence Jest-A00583216.
// June 22,2018.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign05
{
    class DateValidator
    {

        // Method Validate to take strings of year, month, and day and return a 
        // Bool if a dateTime object was created succesfully
        public static bool Validate(string year, string month, string day)
        {
            bool isValid = false;

            string dateInputString = year + "/" + month + "/" + day;

            DateTime dateInput = new DateTime();

            isValid = DateTime.TryParse(dateInputString, out dateInput);

            return isValid;

        }


    }
}
