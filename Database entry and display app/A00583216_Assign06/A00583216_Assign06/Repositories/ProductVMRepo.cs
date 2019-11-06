// Class ProductVMRepo to create a list of ProductVM objects from the foodstore 
// database.
//
//Lawrence Jest-A00583216
// July 14, 2018

using A00583216_Assign06.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace A00583216_Assign06.Repositories
{
    class ProductVMRepo
    {


        public static List<ProductVM> All()
        {

            // Create entity reference.
            FoodStoreEntities db = new FoodStoreEntities();

            // Get columns from Products and Manufacturers tables 
            // having matching mfg columns.
            var query =
                from p in db.Products
                from m in db.Manufacturers
                where p.mfg == m.mfg
                select new
                {
                    p.productID,
                    p.name,
                    p.price,
                    p.mfg,
                    m.mfgDiscount,
                    p.vendor

                };

            // Get columns from previous query and Suppliers table that have 
            // matching vendor columns.
            var query2 = (from q in query
                          from s in db.Suppliers
                          where q.vendor == s.vendor
                          select
                          new
                          {
                              q.productID,
                              q.name,
                              q.price,
                              q.mfg,
                              q.mfgDiscount,
                              q.vendor,
                              s.supplier_email
                          }).ToList();

            // Create the list to return from the previous query.
            List<ProductVM> query3 = (from q2 in query2
                                      select
                                      new ProductVM()
                                      {
                                          ID = q2.productID,
                                          Description = q2.name,
                                          Price = q2.price.Value.ToString("C"),
                                          Manufacturer = q2.mfg,
                                          Mfg_Discount = q2.mfgDiscount.Value.ToString(),
                                          Supplier = q2.vendor,
                                          SupplierContact = q2.supplier_email,

                                      }).ToList();

            return query3;
        }



    }
}
