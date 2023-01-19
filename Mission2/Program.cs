using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Trek Lewis
//This is a dice rolling simulator
namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize random number generator
            Random r = new Random();

            //initialize array for roll totals for each number
            float[] rollTotals = new float[12];

            //get number of rolls from user and convert to integer and output simulator info
            Console.WriteLine("Welcome to the dice rolling simulator!\n\nEnter the number of rolls you'd like to simulate (ex. 24): ");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("\nSIMULATION RESULTS\nEach '*' represents 1% of the total number of rolls.\nTotal number of rolls = " + inputNumber + ".\n");

            //roll 2 dice
            for (int i = 0; i < inputNumber; i++)
            {
                int rolldie1 = r.Next(6);
                int rolldie2 = r.Next(6);

                int rollSum = rolldie1 + rolldie2;

                rollTotals[rollSum]++;
            }
       
            //print all roll totals and percentages
            for (int i = 0; i < 11; i++)
            {
                //find roll total percentage
                float percent = (rollTotals[i] / inputNumber) * 100;

                //add one asterisk for percent of total rolls each roll total accounts for 
                string asterisks = "";
                for (int i2 = 0; i2 < percent; i2++)
                {
                    asterisks += "*";
                }

                //output total rolls and histogram
                Console.WriteLine((i + 2) + ": " + rollTotals[i] + " " + asterisks);

            }
            Console.WriteLine("\nThank you for using my dice rolling simulator, I hope it was easy to grade :-)");
        }
    }
}
