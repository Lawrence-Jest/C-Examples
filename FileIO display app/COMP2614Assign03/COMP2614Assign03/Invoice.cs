//class Invoice to create an invoice object
//
//Lawrence Jest-A00583216
//May 19, 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614Assign03
{
    class Invoice
    {           
        //variables
        public Header header = new Header();
        public List<Item> items = new List<Item>();

        //default constructor
        public Invoice()
        {

        }

        //overloaded constructor
        public Invoice(Header header, List<Item>items)
        {
            this.header = header;
            this.items = items;
        }


       


    }
}
