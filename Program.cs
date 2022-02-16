
//Purpose: Solve a problem by writing a program that uses loops

//Input: Gets user to input increment value

//Output: prints out a Teaspoons to Tablespoons table in increments entered by the user from 1 to 20. Program repeats until the user would like to exit.

//Written by: Abigail Dowell

using System;

namespace Lab3 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARE VARIABLES

            string tempInput = "";
            char selection = 'x';
            const int UpperLimit = 20;
            double i = 0;
            double result = 0;
            double n = 0;



            //CODE HERE
            do {
                Console.WriteLine("**********Conversion Table**********");
                Console.Write("Please enter the increment to be used for your table(must be positive): ");
                tempInput = Console.ReadLine();
                n = Convert.ToInt32(tempInput);

                
                if (n > 0)
                {

                    Console.WriteLine("{0, -15}  {1, 15}", "Tea Spoons", "Table Spoons");
                    Console.WriteLine("{0, -15}  {1, 15}", "==========", "==========");

                    for (i = 1; i <= UpperLimit; i += n)
                    {
                        result = i / 3;
                        Console.WriteLine("{0, -15:0.00} {1, 15:0.00}", i, result);
                    }


                    //checks for exit
                    Console.Write("Would you like to run the program again(Y-Yes): ");
                    tempInput = Console.ReadLine();
                    selection = Convert.ToChar(tempInput);

                    if (selection == 'n')
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid increment.Please enter a positve number.");
                }
            } while (selection != 'n');

        } //eom
    } //eoc
} //eons
