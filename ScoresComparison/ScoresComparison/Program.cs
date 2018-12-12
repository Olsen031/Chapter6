using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ScoresComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[4];
            string userInput;
            int convertedUserInput;
            int highScore = 0;
            int lowScore = 0;
            int scorePlaceHolder;
            int i = 0;


            Write("Please enter a test score from 0-100 >>> ");
                userInput = ReadLine();
                convertedUserInput = Convert.ToInt32(userInput);
                scores[i] = convertedUserInput;
                scorePlaceHolder = scores[i];

            for(i = 1; i <= 3; i++)
            {
                Write("Please enter another test score from 0-100 >>> ");
                userInput = ReadLine();
                convertedUserInput = Convert.ToInt32(userInput);
                scores[i] = convertedUserInput;
            }
            if (scores[0] > scores[1] && scores[2] < scores[1] && scores[3] < scores[2])
            {
                WriteLine("The test scores are as follows: {0} , {1}, {2}, {3}. You did not improve on any test, R.I.P. your GPA",
                    scores[0], scores[1], scores[2], scores[3]);
            }
            else if (scores[3] > scores[2] && scores[2] > scores[1] && scores[1] > scores[0])
            {
                WriteLine("The test scores are as follows: {0} , {1}, {2}, {3}. You improved on every test, Congradulations",
                    scores[0], scores[1], scores[2], scores[3]);
            }
            else
                WriteLine("Your test scores were up and down, down and up");



            
        }
    }
}
