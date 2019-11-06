//class Item to ceate an item object for the invoice class
//
//Lawrence Jest-A00583216
//may 19,2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614Assign03
{
    class Item
    {
        //Item properties
        public int Quantity { set; get; }
        public string Sku { set; get; }
        public string Description { set; get; }
        public float Price { set; get; }
        public string Taxable { set; get; }


        //default constructor
        public Item()
        {

        }


        //overloaded constructor
        public Item(int quantity, string sku, string description, float price,
                    string taxable)
        {
            Quantity = quantity;
            Sku = sku;
            Description = description;
            Price = price;
            Taxable = taxable;

        }





    }
}
