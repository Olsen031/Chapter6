using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int sentinalValue = 999;
            int[] array = new int [8] { 8, 2, 3, 4, 5, 6, 7, 1 };
            string userInput;
            int convertedUserInput;

            Write("Enter a number from 1-9 to view the specific number in the array. Enter 999 to quit. " +
                "Enter a 0 to view in ascending \norder, and a 10 to view in reverse order. >>>>");
            userInput = ReadLine();
            convertedUserInput = Convert.ToInt32(userInput);
            while (convertedUserInput != 999)
            {
                if (convertedUserInput == 0)
                {
                    Array.Sort(array);
                    for (int i = 0; i <= 7; i++)
                    {
                        Write(array[i] + " ");
                    }
                }
                else if (convertedUserInput >= 1 && convertedUserInput <= 9)
                {
                    convertedUserInput = convertedUserInput - 1;
                    WriteLine(array[convertedUserInput]);
                }
                else if (convertedUserInput == 10)
                {
                    Array.Reverse(array);
                    for (int i = 0; i <= 7; i++)
                    {
                        Write(array[i] + " ");
                    }
                }
                Write("Enter a number from 1-9 to view the specific number in the array. Enter 999 to quit. " +
                "Enter a 0 to view \n in ascending order, and a 10 to view in reverse order. >>>>");
                userInput = ReadLine();
                convertedUserInput = Convert.ToInt32(userInput);

            }
           


        }
    }
}
