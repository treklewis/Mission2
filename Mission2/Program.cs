using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize random number generator
            Random r = new Random();

            //initialize array for roll totals for each number
            int[] rollTotals = new int[12];

            //roll 2 dice
            for (int i = 0; i < 100; i++)
            {
                int rolldie1 = r.Next(6);
                int rolldie2 = r.Next(6);

                int rollSum = rolldie1 + rolldie2;

                rollTotals[rollSum]++;
            }
       
            //print all roll totals
            for (int i = 0; i < 11; i++)
            {
                //Console.WriteLine((i + 2) + ": " + rollTotals[i]);
                int percent = ((rollTotals[i] / 100) * 100);

                //add one asterisk for percent of total rolls each roll total accounts for 
                string asterisks = "";
                for (int i2 = 0; i2 < percent; i2++)
                {
                    asterisks += "*";
                }

                Console.WriteLine((i + 2) + ": " + rollTotals[i] + " " + asterisks);

            }
              
        }
    }
}
