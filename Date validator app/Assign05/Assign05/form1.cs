// Class Form1 to create the windows form for the date validator app.
//
// Lawrence Jest-A00583216
// June 22, 2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assign05
{
    public partial class Form1 : Form
    {

        // Constants.
        const int LOWEST_YEAR = 1900;

        // Properties.
        public static string Year { get; set; }

        public static string Month { get; set; }

        public static string Day { get; set; }

        // Initialize the form.
        public Form1()
        {
            InitializeComponent();
        }


        // Load the form.
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Event for check date button click that runs code to validate the info
        // in the textboxes.
        private void checkDateButton_Click(object sender, EventArgs e)
        {
            // Set day, month, year strings from textbox input.
            Day = dayTextBox.Text;

            Month = monthTextBox.Text;

            Year = yearTextBox.Text;

            // value for lowest possible valid year
            int leastYearValueAccepted = LOWEST_YEAR;

            int yearAfterParse;

            bool success = int.TryParse(Year, out yearAfterParse);

            // Check if the textbox input is within the valid range.
            if (yearAfterParse < leastYearValueAccepted)
            {
                Year = "";
            }

            // Validate string inputs.
            bool isValid = DateValidator.Validate(Year, Month, Day);

            // Logic for valid/invalid.  Lowest valid year is 1900, highest is 9999.
            if (isValid == true)
            {
                validLabel.Text = "Valid";

                validLabel.ForeColor = Color.Green;

                // Change tool tip to display Valid.
                toolTip1.SetToolTip(validLabel, "Entered Date is Valid");
            }
            else
            {
                validLabel.Text = "Invalid";

                validLabel.ForeColor = Color.Red;

                // Change tool tip to display Invalid.
                toolTip1.SetToolTip(validLabel, "Entered Date is NOT Valid");
            }

        }

        // Highlights the text in year textbox when tab focused.
        private void yearTextBox_Enter(object sender, EventArgs e)
        {
            yearTextBox.SelectAll();
        }

        // Highlights the text in month textbox when tab focused.
        private void monthTextBox_Enter(object sender, EventArgs e)
        {
            monthTextBox.SelectAll();
        }

        // Highlights the text in day textbox when tab focused.
        private void dayTextBox_Enter(object sender, EventArgs e)
        {
            dayTextBox.SelectAll();
        }
    }
}
