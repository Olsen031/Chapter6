using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zips = {52806, 52807, 52805, 52804, 52803, 52802, 52801, 52800, 58208, 52809};
            string userInput;
            int zipsConverted;
            int i = 0;
            bool wrong = true;

            Write("Please enter a five digit postal zipcode >>> ");
            userInput = ReadLine();
            zipsConverted = Convert.ToInt32(userInput);
            
            while(i < 10)
            {
                if(zipsConverted == zips[i])
                {
                    wrong = false;
                    WriteLine("You are in our delivery area");
                }
                else
                {

                }
                i++;
            }
            if(wrong == false)
            {

            }
            else if(wrong == true)
            {
                WriteLine("You do not live in our delivery area");
            }

            
        }
    }
}
