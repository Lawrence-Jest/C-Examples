// Class Form1 to contain logic for the control of the main windows form for assignment 06.
//
// Lawrence Jest-A00583216
// July 14, 2018


using A00583216_Assign06.Repositories;
using A00583216_Assign06.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace A00583216_Assign06
{
    public partial class Form1 : Form
    {

        // Constants
        const int ID = 0;
        const int DESCRIPTION = 1;
        const int PRICE = 2;
        const int MANUFACTURER = 3;
        const int MFG_DISCOUNT = 4;
        const int SUPPLIER = 5;
        const int SUPPLIER_CONTACT = 6;

        const int ID_COLUMN_WIDTH = 30;
        const int DESCRIPTION_COLUMN_WIDTH = 120;
        const int PRICE_COLUMN_WIDTH = 50;
        const int MANUFACTURER_COLUMN_WIDTH = 100;
        const int MFG_DISCOUNT_COLUMN_WIDTH = 60;
        const int SUPPLIER_COLUMN_WIDTH = 100;
        const int SUPPLIER_CONTACT_COLUMN_WIDTH = 165;

        const int HEADER_COLUMN_AND_ROW_INDEX = -1;

        // Variables.        
        int selectedRow;

        // BindingSource
        BindingSource bs = new BindingSource();

        // Create entity reference.
        FoodStoreEntities db = new FoodStoreEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bs.DataSource = ProductVMRepo.All();

            dataGridViewProducts.DataSource = bs;

            // Once the DataGridView is defined, format its columns.
            setUpColumns();

            // Get list for drop down menus.
            LoadSupplierList();

            LoadManufacturerList();

        }


        // Method to setup column spacing, names, and alignment.
        private void setUpColumns()
        {
            dataGridViewProducts.Columns[ID].Width = ID_COLUMN_WIDTH;

            dataGridViewProducts.Columns[DESCRIPTION].Width = DESCRIPTION_COLUMN_WIDTH;

            dataGridViewProducts.Columns[PRICE].Width = 50;

            dataGridViewProducts.Columns[PRICE].DefaultCellStyle.Alignment
            = DataGridViewContentAlignment.TopRight;

            dataGridViewProducts.Columns[MANUFACTURER].Width = MANUFACTURER_COLUMN_WIDTH;

            dataGridViewProducts.Columns[MFG_DISCOUNT].Width = MFG_DISCOUNT_COLUMN_WIDTH;

            dataGridViewProducts.Columns[MFG_DISCOUNT].HeaderText = "Mfg" + "\n" + "Discount";

            dataGridViewProducts.Columns[MFG_DISCOUNT].DefaultCellStyle.Alignment
                = DataGridViewContentAlignment.TopRight;

            dataGridViewProducts.Columns[SUPPLIER].Width = SUPPLIER_COLUMN_WIDTH;

            dataGridViewProducts.Columns[SUPPLIER_CONTACT].Width = SUPPLIER_CONTACT_COLUMN_WIDTH;
        }


        // Method to load the combo box with suppliers from database.
        private void LoadSupplierList()
        {
            comboBoxSupplierAddProducts.Items.Clear();

            var query = (from s in db.Suppliers

                         select new
                         {
                             s.vendor

                         }).Distinct().ToList();

            foreach (var item in query)
            {
                comboBoxSupplierAddProducts.Items.Add(item.vendor);
            }
        }


        // Method to load the combo box with manufacturers from the database.
        private void LoadManufacturerList()
        {
            comboBoxManufacturerAddProducts.Items.Clear();

            var query2 = (from m in db.Manufacturers

                          select new
                          {
                              m.mfg

                          }).Distinct().ToList();

            foreach (var item in query2)
            {
                comboBoxManufacturerAddProducts.Items.Add(item.mfg);
            }
        }


        // Method to update complete form to be used after changes from the user.
        private void updateForm()
        {
            bs.DataSource = ProductVMRepo.All();

            dataGridViewProducts.DataSource = bs;

            LoadManufacturerList();

            LoadSupplierList();

        }


        private void dataGridViewProducts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            // Only enable delete option if row selected is not the header
            if (e.RowIndex != HEADER_COLUMN_AND_ROW_INDEX
                && e.ColumnIndex != HEADER_COLUMN_AND_ROW_INDEX)
            {
                selectedRow = e.RowIndex;

                toolStripMenuItemDeleteRow.Enabled = true;
            }
            // Header is selected so disable 'Row Delete'.
            else
            {
                toolStripMenuItemDeleteRow.Enabled = false;
            }

        }



        private void toolStripMenuItemDeleteRow_Click(object sender, EventArgs e)
        {
            bool success;

            string IDToDelete = "";

            try
            {
                // Get the item to delete from the row selected.          
                IDToDelete = dataGridViewProducts.Rows[selectedRow].Cells[ID].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot delete empty row. ", "Delete Confirmation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            try
            {
                // Pass data to the delete method and use bool success for 
                //completeion of request.
                success = ProductRepo.Delete(IDToDelete);

                if (success == true)
                {

                    MessageBox.Show("Product deleted.", "Delete Confirmation",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Remove row if one is selected.
                    dataGridViewProducts.Rows.RemoveAt(selectedRow);

                    // Reset value so no rows are selected.
                    selectedRow = -1;

                }
                else
                {
                    MessageBox.Show("This product has already been invoiced so it cannot be deleted",
                                    "Delete Confirmation", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                }
            }
            catch (Exception exc)
            {

            }

            updateForm();

        }


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void importDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            ProductRepo.ReadFromCSVFile();

            updateForm();

        }


        private void buttonAddProducts_Click(object sender, EventArgs e)
        {
            string description = textBoxDescriptionAddProducts.Text;

            decimal price = 0.0m;

            Decimal.TryParse(textBoxPriceAddProducts.Text, out price);

            string manufacturer = comboBoxManufacturerAddProducts.Text;

            string supplier = comboBoxSupplierAddProducts.Text;

            bool successfulDescription;

            bool successfulPrice;

            bool successfulManufacturer;

            bool successfulSupplier;

            // Check for empty string.
            if (textBoxDescriptionAddProducts.Text != string.Empty)
            {
                successfulDescription = true;
            }
            else
            {
                successfulDescription = false;
            }

            // Check for empty string.
            if (textBoxPriceAddProducts.Text != string.Empty)
            {
                successfulPrice = true;
            }
            else
            {
                successfulPrice = false;
            }

            // Check fro empty string.
            if (comboBoxManufacturerAddProducts.Text != string.Empty)
            {
                successfulManufacturer = true;
            }
            else
            {
                successfulManufacturer = false;
            }

            // Check for empty string.
            if (comboBoxSupplierAddProducts.Text != string.Empty)
            {
                successfulSupplier = true;
            }
            else
            {
                successfulSupplier = false;
            }

            // Check if all user input is valid.
            if (successfulDescription && successfulManufacturer && successfulPrice &&
                successfulSupplier)
            {
                try
                {
                    ProductRepo.Create(description, manufacturer, price, supplier);

                    MessageBox.Show("Success", "Add Product Confirmation",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception exce)
                {

                }

                updateForm();
            }


        }

        private void manufacturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManufacturerInput formManufacturerInput = new FormManufacturerInput();

            formManufacturerInput.StartPosition = FormStartPosition.CenterParent;

            formManufacturerInput.ShowInTaskbar = false;

            DialogResult result = formManufacturerInput.ShowDialog();

            if (result == DialogResult.OK)
            {
                updateForm();
            }
        }

        private void textBoxDescriptionAddProducts_Validating(object sender, CancelEventArgs e)
        {
            // regex for letters only.
            Regex regex = new Regex(@"(^[A-Za-z]*$)");

            Match match = regex.Match(textBoxDescriptionAddProducts.Text);

            // Only allow letters.
            if (match.Success)
            {
                errorProvider1.SetError(textBoxDescriptionAddProducts, string.Empty);
            }
            else
            {
                errorProvider1.SetError(textBoxDescriptionAddProducts, "Numeric characters not allowed.");
            }

            // Do not allow empty input.
            if (textBoxDescriptionAddProducts.Text == string.Empty)
            {
                errorProvider1.SetError(textBoxDescriptionAddProducts, "Cannot be empty.");
            }

        }

        private void textBoxPriceAddProducts_Validating(object sender, CancelEventArgs e)
        {
         
            var validated = false;

            decimal number;

            // Parse currency value using current culture. 
            var value = textBoxPriceAddProducts.Text;

            var style = System.Globalization.NumberStyles.Number;

            var culture = System.Globalization.CultureInfo.InvariantCulture;

            Decimal.TryParse(value, style, culture, out number);

            if (number > 0)    // Check if the value is not negative or zero
                {
                    validated = true;
                }
                   

            // Only allow numbers using our current currency system, includes commas 
            // and decimal place.
            if (validated)
            {
                errorProvider1.SetError(textBoxPriceAddProducts, string.Empty);
            }
            else
            {
                errorProvider1.SetError(textBoxPriceAddProducts, "Numeric characters only.");
            }

            // Do not allow empty input.
            if (textBoxPriceAddProducts.Text == string.Empty)
            {
                errorProvider1.SetError(textBoxPriceAddProducts, "Price field cannot be empty.");
            }


        }

        private void comboBoxManufacturerAddProducts_Validating(object sender, CancelEventArgs e)
        {

            // Do not allow empty input.
            if (comboBoxManufacturerAddProducts.Text == string.Empty)
            {
                errorProvider1.SetError(comboBoxManufacturerAddProducts,
                                        "Manufacturer field cannot be empty.");
            }
            else
            {
                errorProvider1.SetError(comboBoxManufacturerAddProducts, string.Empty);
            }
        }

        private void comboBoxSupplierAddProducts_Validating(object sender, CancelEventArgs e)
        {

            // Do not allow empty input.
            if (comboBoxSupplierAddProducts.Text == string.Empty)
            {
                errorProvider1.SetError(comboBoxSupplierAddProducts,
                                        "Supplier field cannot be empty.");
            }
            else
            {
                errorProvider1.SetError(comboBoxSupplierAddProducts, string.Empty);
            }

        }
    }
}
