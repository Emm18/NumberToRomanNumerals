using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToRomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert Number to Roman Numerals
            //I = 1 , V = 5, X = 10, L = 50 , C = 100, D = 500, M = 1000
            //1-3999
            //Example
            // Input = 94
            // Output = XCIV
            // No validations - Only input numbers

            Console.WriteLine("Please Enter A Number = ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            string thousandsCtr = "";
            string hundredsCtr = "";
            string tensCtr = "";
            string onesCtr = "";
            string[] thousands = new string[] { "M", "MM", "MMM" };
            string[] hundreds = new string[] { "C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};
            string[] tens = new string[] { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            if (userInput > 0 && userInput < 4000) { 
                while(userInput != 0) //keep looping until userInput goes down to 0
                {
                    if (userInput >= 1000 && userInput <= 3999) //getting thousands
                    {
                    thousandsCtr = thousands[(userInput / 1000)-1];
                    userInput = userInput - ((userInput / 1000)*1000);
                    }
                    else if (userInput >= 100 && userInput <= 999) //hundreds
                    {
                    hundredsCtr = hundreds[(userInput/100)-1];
                    userInput = userInput - ((userInput / 100) * 100);
                    }
                    else if (userInput >= 10 && userInput <= 99) //tens
                    {
                    tensCtr = tens[(userInput / 10) - 1];
                    userInput = userInput - ((userInput / 10) * 10);
                    }
                    else if (userInput < 10 && userInput > 0) //ones
                    {
                    onesCtr = ones[userInput - 1];
                    userInput = userInput - userInput;
                    }
                }
                Console.WriteLine(thousandsCtr + hundredsCtr + tensCtr + onesCtr);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }  
        }
    }
}
