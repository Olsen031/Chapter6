using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceList = { 200, 180, 160, 145 };
            string userInput;
            int convertedNights;
            int price = 0;
            int totalAmountDue;

            Write("Please enter the number of nights you wish to stay at our resort >>> ");
            userInput = ReadLine();
            convertedNights = Convert.ToInt32(userInput);

            if (convertedNights == 1 || convertedNights == 2)
                price = priceList[0];
            else if (convertedNights == 3 || convertedNights == 4)
                price = priceList[1];
            else if (convertedNights == 5 || convertedNights == 6 || convertedNights == 7)
                price = priceList[2];
            else if (convertedNights >= 8)
                price = priceList[3];
            else
                WriteLine("You have entered a negative number of days, such stupidity will not be allowed to stay at our resort.");

            totalAmountDue = convertedNights * price;
            if(convertedNights >= 1)
            WriteLine("Your desired number of days at our resort is " + convertedNights + " which will amount to " + totalAmountDue.ToString("C"));






            
            
           
        }
    }
}
