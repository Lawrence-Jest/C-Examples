//Class InvoiceStringSplitter to split strings of invoice data
//
//Lawrence Jest-A00583216
//may 19, 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614Assign03
{
    class InvoiceStringSplitter
    {

        const int HEADER_ELEMENT = 0;

        //constants for header components as thier respective array element number
        const int FIRST_HEADER_COMPONENT = 0;
        const int SECOND_HEADER_COMPONENT = 1;
        const int THIRD_HEADER_COMPONENT = 2;

        //constants for item components as their respective array element number
        const int FIRST_ITEM_COMPONENT = 0;
        const int SECOND_ITEM_COMPONENT = 1;
        const int THIRD_ITEM_COMPONENT = 2;
        const int FOURTH_ITEM_COMPONENT = 3;
        const int FIFTH_ITEM_COMPONENT = 4;

        //constants for extraction of discount terms to do with length of
        //discount in days
        const int START_LETTER_DAYS = 1;
        const int SUBGROUP_LEN_DAYS = 2;

        //constants for extraction of discount terms to do with percentage of
        //discount
        const int START_LETTER_PERCENT = 0;
        const int SUBGROUP_LEN_PERCENT = 1;

        //constant for changing from whole number to percentage
        const int CHANGE_TO_PERCENT = 100;


        //meth0d to return a header object from an array of invoice strings
        public Header createHeaderObjectFromStringArray(string[] headerAndItemsArray)
        {
            Header header = new Header();

            string[] headerVariables = headerAndItemsArray[HEADER_ELEMENT].Split(':');

            header.InvoiceNumber = headerVariables[FIRST_HEADER_COMPONENT];

            header.InvoiceDate = DateTime.Parse(headerVariables[SECOND_HEADER_COMPONENT]);

            int discountTerms;

            int.TryParse(headerVariables[THIRD_HEADER_COMPONENT], out discountTerms);

            //get discount length and convert to int
            string discountTermDaysString =
                discountTerms.ToString().Substring(
                START_LETTER_DAYS, SUBGROUP_LEN_DAYS);

            int discountTermDays;

            bool success = int.TryParse(discountTermDaysString,
                           out discountTermDays);

            header.DiscountTermDays = discountTermDays;

            //get discount amount and convert to float percent
            string discountTermPercentString =
                   discountTerms.ToString().Substring(
                   START_LETTER_PERCENT, SUBGROUP_LEN_PERCENT);

            float discountTermDiscountPercent;

            bool didItSucceed = float.TryParse(discountTermPercentString,
                                out discountTermDiscountPercent);

            header.DiscountTermDiscountPercent =
                discountTermDiscountPercent / CHANGE_TO_PERCENT;

            return header;
        }


        //method to return an item object from an array of invoices
        public Item createItemObjectFromStringArray(string[] itemVariables)
        {
            Item newItem = new Item();           

            int quantity;

            int.TryParse(itemVariables[FIRST_ITEM_COMPONENT], out quantity);

            newItem.Quantity = quantity;

            newItem.Sku = itemVariables[SECOND_ITEM_COMPONENT];

            newItem.Description = itemVariables[THIRD_ITEM_COMPONENT];

            float price;

            float.TryParse(itemVariables[FOURTH_ITEM_COMPONENT], out price);

            newItem.Price = price;

            newItem.Taxable = itemVariables[FIFTH_ITEM_COMPONENT];   
            
            return newItem;
        }



        //method to split each string in the array of invoices into an invoice 
        //object and save those invoice objects to list of invoices
        public List<Invoice> splitIntoInvoices(string[] stringArrayOfInvoices)
        {
            List<Invoice> invoiceList = new List<Invoice>();

            foreach (string invoice in stringArrayOfInvoices)
            {
                Header header = new Header();

                Invoice newInvoice = new Invoice();

                List<Item> itemList = new List<Item>();

                //split invoice string at '|'.
                List<string> headerAndItems = invoice.Split('|').ToList();
                 
                string[] headerAndItemsArray = headerAndItems.ToArray();

                //extract header data from invoice string.
                header = createHeaderObjectFromStringArray(headerAndItemsArray);               

                //extract item data from invoice string.
                //loop starts at 1 because header is at element 0, items start 
                //at element 1
                for (int j = 1; j < headerAndItemsArray.Length; j++)
                {
                    Item newItem = new Item();

                    //split string for item data.
                    string[] itemVariables = headerAndItemsArray[j].Split(':');                    

                    //create item to add to itemList.
                   newItem = createItemObjectFromStringArray(itemVariables);

                    itemList.Add(newItem);
                }

                //add header data to a new invoice object.
                newInvoice.header = header;

                //add itemlist data to a new invoice object.
                newInvoice.items = itemList;

                //add the invoice to a list of invoices.
                invoiceList.Add(newInvoice);
            }
            return invoiceList;
        }


    }
}
