// Class ProductRepo to Create, ReadFromCSVFile, and Delete Product objects 
// From foodstore Database.
//
// Lawrence Jest-A00583216
// July 14, 2018

using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A00583216_Assign06.Repositories
{
    class ProductRepo
    {
        // Constants
        public const int PRODUCT_NAME = 0;
        public const int MANUFACTURER = 1;
        public const int PRICE = 2;
        public const int VENDOR = 3;
        public const int UNIQUE_KEY_AMOUNT_TO_ADD = 1;

        // Method to add a product to the database.
        public static void Create(string productName, string mfg, decimal price, string vendor)
        {
            // Connect to database. 
            FoodStoreEntities context = new FoodStoreEntities();

            // Build an ObjectQuery instance to retrieve all products.
            var products = from p in context.Products
                           select p.productID;

            // Use the ObjectQuery to find how many there are. 
            int max = products.Max();

            // Add 1 to create a new unique key larger than the last.
            int newKey = max + UNIQUE_KEY_AMOUNT_TO_ADD;


            Product product = new Product()
            {
                productID = newKey,
                name = productName,
                mfg = mfg,
                price = price,
                vendor = vendor
            };

            context.Products.Add(product);

            context.SaveChanges();
        }


        // Method to import a csv file of products to database.
        public static void ReadFromCSVFile()
        {
            // Location line to be read from csv.
            int location = 0;

            const string FILTER = "CSV documents (.csv,*.csv)|*.csv;*.csv";


            OpenFileDialog dlg = new OpenFileDialog();

            dlg.FileName = "Document"; // Default file name

            dlg.DefaultExt = ".csv";   // Default file extension

            dlg.Filter = FILTER; // Default file type

            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                List<string> csvLines = new List<string>();

                List<string> dataForVMObject = new List<string>();

                string filepath = dlg.FileName;

                StreamReader sr = new StreamReader(filepath, false);

                // Add each line of csv file to a list of strings 
                while (!sr.EndOfStream)
                {
                    string input = sr.ReadLine();

                    csvLines.Add(input);

                }

                // split the line from previous list on ',' and 
                // create the product object with the split strings
                foreach (string item in csvLines)
                {
                    dataForVMObject = item.Split(',').ToList();

                    decimal price = 0.0m;

                    Decimal.TryParse(dataForVMObject[PRICE], out price);

                    try
                    {
                        location++;

                        Create(dataForVMObject[PRODUCT_NAME], dataForVMObject[MANUFACTURER], price, dataForVMObject[VENDOR]);


                    }
                    catch (Exception e)
                    {

                        MessageBox.Show("An error exists on line " + location +
                                        " of the imported file. This entry has been skipped ", "Error Notification",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                sr.Close();
            }
            else if (result == DialogResult.Cancel)
            {
            }
        }


        // Mehtod to delete a product from the database.
        public static bool Delete(string IDToDelete)
        {


            bool successfulDelete;

            // Create entity reference.
            FoodStoreEntities db = new FoodStoreEntities();

            try
            {
                // Product to delete.
                var product = db.Products.Where(p => p.productID.ToString() == IDToDelete)
                             .FirstOrDefault();

                db.Products.Remove(product);

                db.SaveChanges();

                successfulDelete = true;

                return successfulDelete;
            }

            catch (DbUpdateException e)
            {
                successfulDelete = false;

                return successfulDelete;
            }

        }

    }

}
