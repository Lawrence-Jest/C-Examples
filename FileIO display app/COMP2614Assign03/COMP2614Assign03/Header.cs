//Class Header to create a header object for an invoice
//
//Lawrence Jest-A00583216
//May 19, 2018


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614Assign03
{
    class Header
    {
        //Header properties
        public string InvoiceNumber { set; get; }
        public DateTime InvoiceDate { set; get; }        
        public int DiscountTermDays { set; get; }
        public float DiscountTermDiscountPercent { set; get; }


        //default constructor
        public Header()
        {

        }

        //overLoaded constructor
        public Header(string invoiceNumber, DateTime invoiceDate,
                       int discountTermDays, float discountTermDiscountPercent)
        {
            InvoiceNumber = invoiceNumber;
            InvoiceDate = invoiceDate;
            DiscountTermDays = discountTermDays;
            DiscountTermDiscountPercent = discountTermDiscountPercent;
        }






    }
}
