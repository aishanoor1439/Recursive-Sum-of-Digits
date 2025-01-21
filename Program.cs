using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Sum_of_Digits
{
    internal class Program
    {
        static int SumOfDigits(int number)
        {
            if (number == 0)
                return 0;
            return (number % 10) + SumOfDigits(number / 10);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a non-negative integer to calculate the sum of its digits: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }
            else
            {
                int result = SumOfDigits(input);
                Console.WriteLine($"The sum of the digits of {input} is: {result}");
            }
        }
    }
}
