using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            int[] numbers = new int[5];
            int biggerThanFive = 0;
            Console.WriteLine("I need 5 numbers.");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The largest number is " + numbers.Max());
            Console.WriteLine("The smallest number is " + numbers.Min());
            Console.WriteLine("The sum is " + numbers.Sum());
            Console.WriteLine("The average is " + ((double)numbers.Sum()/numbers.Length));  // Manually calculate the average
            // Console.WriteLine("The average is " + numbers.Average());   This is the better solution
            Console.WriteLine();

            // Loop through the array backwards challenge
            Console.WriteLine("Here are the numbers in reverse order:");
            for (int i = numbers.Length - 1; i >= 0; i--) // We start at the last index (Length-1) and end at zero.
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // Loop through the array and only print values bigger than 5
            Console.WriteLine("Numbers larger than 5 are:");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 5)
                {
                    Console.Write(numbers[i] + " ");
                    biggerThanFive += 1;    // Counts the number of values bigger than 5 challenge
                }
                    
            }
            Console.WriteLine();
            Console.WriteLine("There are " + biggerThanFive + " numbers larger than 5.");
         
            Console.ReadLine();
        }
    }
}
