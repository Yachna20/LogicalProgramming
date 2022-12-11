using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PerfectNumber
    {
        public void Perfect()
        {
            Console.WriteLine("Check given number is perfect number OR not");
            Console.WriteLine("Enter a Number ");
            int number = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine(number + " is a Perfect Number");
            }
            else
            {
                Console.WriteLine(number + " is Not a Perfect Number");
            }
        }
    }
}
