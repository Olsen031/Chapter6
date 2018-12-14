using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ZipCodeWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput;
            int zipsConverted;


            Write("Please enter a five digit postal zipcode >>> ");
            userInput = ReadLine();
            zipsConverted = Convert.ToInt32(userInput);
            displayZipCodes(zipsConverted);

        }

        static public void displayZipCodes(int enteredZipCode)
        {
            int[] zips = { 52806, 52807, 52805, 52804, 52803, 52802, 52801, 52800, 58208, 52809 };
            int i = 0;
            bool wrong = true;
            while (i < 10)
            {
                if (enteredZipCode == zips[i])
                {
                    wrong = false;
                    WriteLine("You are in our delivery area");
                }
                else
                {

                }
                i++;
            }
            if (wrong == false)
            {

            }
            else if (wrong == true)
            {
                WriteLine("You do not live in our delivery area");
            }
        }



    }
}
