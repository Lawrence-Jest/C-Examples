// Class FormMAnufacturerInput to hold logic for the Add Manufacturer Dialog window form
// 
// Lawrence Jest-A00583216
// July 14, 2018

using A00583216_Assign06.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A00583216_Assign06
{
    public partial class FormManufacturerInput : Form
    {
        public FormManufacturerInput()
        {
            InitializeComponent();
        }



        private void FormManufacturerInput_Load(object sender, EventArgs e)
        {

        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }



        private void buttonOk_Click(object sender, EventArgs e)
        {
            string manufacturer = textBoxManufacturerName.Text;

            decimal manufacturerDiscount = 0.0m;

            decimal.TryParse(textBoxMaufacturerDiscount.Text, out manufacturerDiscount);

            bool successfulDiscount;

            bool successfulName;

            // Check for whole numbers and empty strings.
            if (manufacturerDiscount % 1 == 0 && textBoxMaufacturerDiscount.Text != string.Empty)
            {
                successfulDiscount = true;
            }
            else
            {
                successfulDiscount = false;
                MessageBox.Show("Invalid discount. A whole number is required.",
                                 "Manufacturer Add Confirmation",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Check for empty strings
            if (textBoxManufacturerName.Text != string.Empty)
            {
                successfulName = true;
            }
            else
            {
                successfulName = false;
                MessageBox.Show("Name field cannot be blank.",
                                "Manufacturer Add Confirmation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // If input data is valid save the manufacturer object in the database. 
            if (successfulName && successfulDiscount)
            {
                try
                {
                    ManufacturerRepo.Create(manufacturer, manufacturerDiscount);

                    MessageBox.Show("Success", "Manufacturer Add Confirmation",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    DialogResult = DialogResult.OK;

                    Dispose();
                }
                catch (Exception exece)
                {
                    MessageBox.Show("Could not add manufacturer, manufacturer already in database",
                                    "Manufacturer Add Confirmation",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }
    }
}
