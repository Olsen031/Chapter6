using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ZipCodeWithMethods
{
    class ZipCodes
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

    }
}
