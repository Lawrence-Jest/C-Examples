// Class ManufacturerRepo to create a new manufacturer object in the foodstores database
//
// Lawrence Jest-A00583216
// July 14, 2018


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A00583216_Assign06.Repositories
{
    class ManufacturerRepo
    {

        // Method to add a manufacturer object to the database.
        public static void Create(string manufacturer, decimal manufacturerDiscount)
        {
            // Get database connection.
            FoodStoreEntities db = new FoodStoreEntities();

            Manufacturer newManufacturer = new Manufacturer()
            {
                mfg = manufacturer,
                mfgDiscount = manufacturerDiscount
            };

            db.Manufacturers.Add(newManufacturer);

            db.SaveChanges();
        }

    }
}
