//class Dispaly to display the recipt for a list of invoices
//
//Lawrence Jest-A00583216
//May 20, 2018


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614Assign03
{
    class Display
    {
        //constants for format
        const string TITLE = "Invoice Listing";
        const string HYPHEN_LINE = "-----------------------------------------------------------------";
        const string HEADER_FORMAT = "{0, -16}{1, -15}";
        const string TERM_FORMAT = "{0, -16}{1, 0:P2} {2} {3}";
        const string INVOICE_TITLE_FORMAT = "{0, 3} {1, -12}{2, -20}{3, 12}{4, 4}{5, 13}";
        const string INVOICE_DATA_FORMAT = "{0, 3} {1, -12}{2, -20}{3, 12:N2}{4, 3}{5, 14:N2}";
        const string INVOICE_TOTAL_FORMAT = "{0, 16}{1, -10}{2, 39:N2}";

        //constants for gst and pst
        const float GST_AMOUNT = 0.05f;
        const float PST_AMOUNT = 0.07f;          
       
              

        //method to display the title
        public void displayTitle()
        {
            Console.WriteLine("{0}", TITLE);

            Console.WriteLine("{0}", HYPHEN_LINE);

            Console.WriteLine();

        }


        //method to display the header of the invoice
        public void displayHeader(Invoice invoice)
        {
            //invoice number
            Console.Write(HEADER_FORMAT, "Invoice Number: ",
                          invoice.header.InvoiceNumber);

            Console.WriteLine();


            //invoice date
            Console.Write(HEADER_FORMAT, "Invoice Date: ",
                          invoice.header.InvoiceDate.ToString("MMM dd, yyyy"));

            Console.WriteLine();

            //invoice date with discount time added
            Console.Write(HEADER_FORMAT, "Discount Date: ",
                         invoice.header.InvoiceDate.AddDays
                         (invoice.header.DiscountTermDays).ToString("MMM dd, yyyy"));

            Console.WriteLine();

            //invoice discount terms and length
            Console.Write(TERM_FORMAT, "Terms: ",
                          invoice.header.DiscountTermDiscountPercent,
                          invoice.header.DiscountTermDays + " days", "ADI");

            Console.WriteLine();

            Console.WriteLine("{0}", HYPHEN_LINE);

        }



        //method to display the title bar
        public void displayTitleBar()
        {
            //invoice title bar
            Console.WriteLine(INVOICE_TITLE_FORMAT, "Qty",
                                                    "SKU",
                                                    "Description",
                                                    "Price",
                                                    "PST",
                                                    "Ext");

            Console.WriteLine("{0}", HYPHEN_LINE);

        }
       


        //method to display the items in the invoice including total price of
        //all items
        public float displayItem(Item item, float totalPriceOfitems)
        {           
            //price of item * quantity
            float totalPrice = item.Price * item.Quantity;

            Console.WriteLine(INVOICE_DATA_FORMAT, item.Quantity,
                                                   item.Sku,
                                                   item.Description,
                                                   item.Price,
                                                   item.Taxable,
                                                   totalPrice);
            //total price of all items
            totalPriceOfitems = totalPrice + totalPriceOfitems;
            return totalPriceOfitems;

        }


        //method to calculate the pst on the items in the invoice
        public float calculatePST(Item item, float totalPST)
        {          

            if (item.Taxable.ToUpper() == "Y")
            {
                float PSTperItem = 0f;

                float totalPrice = item.Price * item.Quantity;


                PSTperItem = totalPrice * PST_AMOUNT;

                totalPST = totalPST + PSTperItem;
            }

            return totalPST;
        }

        //method to display sub total and total
        public void displayInvoiceTotals(Invoice invoice, float totalPriceOfitems, float totalPST)
        {
            Console.WriteLine("{0}", HYPHEN_LINE);

            //get gst total
            float totalGST = totalPriceOfitems * GST_AMOUNT;

            //print subtotal and gst
            Console.WriteLine(INVOICE_TOTAL_FORMAT, "", "SubTotal:",
                                                    totalPriceOfitems);

            Console.WriteLine(INVOICE_TOTAL_FORMAT, "", "GST:", totalGST);

            //print pst amount
            if (totalPST > 0)
            {
                Console.WriteLine(INVOICE_TOTAL_FORMAT, "", "PST:", totalPST);
            }

            Console.WriteLine("{0}", HYPHEN_LINE);

            //total price of invoice
            float totalPriceOfInvoice = totalPriceOfitems + totalPST + totalGST;

            Console.WriteLine(INVOICE_TOTAL_FORMAT, "", "Total:", totalPriceOfInvoice);

            Console.WriteLine();

            //total discount not applied to total
            float totalDiscount = totalPriceOfInvoice * invoice.header.DiscountTermDiscountPercent;

            Console.WriteLine(INVOICE_TOTAL_FORMAT, "", "Discount:", totalDiscount);


        }




        //method to display the invoices
        public void displayInvoices(List<Invoice> invoiceList)
        {
            displayTitle();

            foreach (Invoice invoice in invoiceList)
            {
                displayHeader(invoice);

                displayTitleBar();                           
                                
                float totalPriceOfitems = 0f;  
                
                float totalPST = 0f;

                //list of each item
                foreach (Item item in invoice.items)
                {            
                    //display items and return total price of all items
                    totalPriceOfitems = displayItem( item, totalPriceOfitems);
                                   
                    totalPST = calculatePST(item, totalPST);
                }               

                displayInvoiceTotals(invoice, totalPriceOfitems, totalPST);
             
                Console.WriteLine();

                Console.WriteLine();

                Console.WriteLine();
            }

        }        

    }
}
