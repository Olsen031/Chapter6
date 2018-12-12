using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperature = new double[7];
            double[] temperatureTextSorted = new double[7];
            string userInput;
            double total = 0;
            double average;
            double difference;
            int days = 0;


            for (int k = 0; k <= 6; k++)
            {
                days++;
                Write("Enter the a value in degrees Fahrenheit for day " + days + " >>> ");
                userInput = ReadLine();
                temperature[k] = Convert.ToDouble(userInput);

            }
            days = 0;
            temperatureTextSorted = temperature;
            Array.Sort(temperatureTextSorted);
            Write("The temperatures in acsending order is ");
            for (int i = 0; i <= 6; i++)
            {
                Write(temperatureTextSorted[i] + ", ");
                total = total + temperatureTextSorted[i];
            }
            average = total / 7;
            WriteLine("The average tempearature is " + average + " degrees Fahrenheit");
            for(int l = 0; l <= 6; l++)
            {
                days++;
                difference = temperature[l] - average;
                if(difference > average)
                {
                    WriteLine("The temperature for day " + days + " is " + Math.Round(difference , 2) + " degrees higher than the average");
                }
                else if(difference < average)
                {
                    difference = Math.Abs(difference);
                    WriteLine("The temperature for day " + days + " is " + Math.Round(difference , 2) + " degrees lower than the average");
                }
                else
                {
                    WriteLine("The temperature for day " + days + " is the same as the average");
                }
            }

            



        }
    }
}
