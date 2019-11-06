//Class FileIO to read invoices sent as .txt files
//
//Lawrence Jest-A00583216
//May 19, 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace COMP2614Assign03
{
    class FileIO
    {
        //properties
        public string inputString { set; get; }

        public List<string> InvoiceStringList { get => invoiceStringList;
                                                set => invoiceStringList = value; }

        public string[] invoiceStringArray;

        private List<string> invoiceStringList = new List<string>();

        //to read from a file and create array of invoice strings
        public string[] readFromFile(string filePath)
        {

            StreamReader sr = null;
            
            //read from filepath and convert to list of strings
            try
            {

                sr = new StreamReader(filePath);

                while (!sr.EndOfStream)
                {
                    inputString = sr.ReadLine();

                    InvoiceStringList.Add(inputString);                                   
                  
                }

                invoiceStringArray = InvoiceStringList.ToArray();

            }

            //catch IO errors
            catch(Exception e)
            {
                Console.WriteLine("Read Error:" + e.Message);
            }

            return invoiceStringArray;
        }
    }
}
