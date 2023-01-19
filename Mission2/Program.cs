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
            int[] rollTotals = new int[6];

            //roll die
            for (int i = 0; i < 100; i++)
            {
                int roll = r.Next(6);

                rollTotals[roll]++;
            }
       
            //print all roll totals
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(rollTotals[i]);
            }
              
        }
    }
}
