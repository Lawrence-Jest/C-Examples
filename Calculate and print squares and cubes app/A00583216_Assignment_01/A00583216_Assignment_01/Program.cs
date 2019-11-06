//A00583216_Assignment_01: to create a program to calculate the squares and cubes 
//of the even numbers from 0 to 20 and print the resulting values in table format
//
//Author:Lawrence Jest-A00583216
//Date:May 5, 2018



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A00583216_Assignment_01
{
    class Program
    {
        private const string FORMAT = "{0, 8:N0} {1, 10:N0} {2, 10:N0}";
        private const string HYPHENLINE = "------------------------------";
       

        static void Main(string[] args)
        {
            //variables
            string numbersHeader = "number";
            string squareHeader = "square";
            string cubeHeader = "cube";

            int number;
            int square;
            int cube;
            int sumNumber = 0;
            int sumSquare = 0;
            int sumCube = 0;

            //Header
            Console.WriteLine(FORMAT, numbersHeader, squareHeader, cubeHeader);
            Console.WriteLine(HYPHENLINE);

            //body
            for (int index = 0; index < 11; ++index)
            {
               
                number = index + index;
                square = number * number;
                cube = number * number * number;
                sumNumber = sumNumber + number;
                sumSquare = sumSquare + square;
                sumCube = sumCube + cube;
                Console.WriteLine(FORMAT, number, square, cube);
            }

            //sum
            Console.WriteLine(HYPHENLINE);
            Console.WriteLine(FORMAT, sumNumber, sumSquare, sumCube);
            
            //pause and exit
            Console.WriteLine();
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
