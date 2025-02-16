using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a List called "numbers" - DONE!
            List<int> numbers = new List<int>(); //DO NOT ERASE THIS! You will use this in the exercise.

            //-----START HERE------------------------------------------

            int num;
            num = 0;

            do
            {
                num++;
                numbers.Add(num);
            } while (num < 100);

            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }

            Console.WriteLine("Increase:");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("\nDecrease:");

           for (int i = 199; i >= 0; i--)
            {
                //TODO - Inside the loop, place numbers[i] inside of the Console.WriteLine() method
                Console.WriteLine(numbers[i]); // Example placement of numbers[i] inside Console.WriteLine
            }

        }
    }
}