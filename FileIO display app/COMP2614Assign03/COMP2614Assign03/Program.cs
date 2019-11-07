//class Program to run the application for processing invoice data
//
//Lawrence Jest-A00583216
//May 19, 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614Assign03
{
    class Program
    {        

        static void Main(string[] args)
        {
            
            //file must be placed in main folder of program
            string userEnteredFileName;
            string fileLocation = "../../../";
            string filePath;
            string[] invoiceStringArray;


            //get file name from user
            Console.WriteLine("Enter filename to load (Invoicedata.txt for testing):");
            Console.WriteLine();

            userEnteredFileName = Console.ReadLine().Trim();//trim in case of 
                                                            // typed spaces
            Console.WriteLine();

            Console.WriteLine();

            filePath = fileLocation + userEnteredFileName;

            //read from file
            FileIO io = new FileIO();

            invoiceStringArray = io.readFromFile(filePath);
            
            InvoiceStringSplitter splitter = new InvoiceStringSplitter();

            //use array to create invoice objects as a list
            List<Invoice> invoiceList = splitter.splitIntoInvoices(invoiceStringArray);            
            
            //create new display object and display the list of invoices read from
            //file
            Display display = new Display();            

            display.displayInvoices(invoiceList);

            Console.WriteLine("Press return to exit.");

            Console.ReadLine();
        }
    }
}
