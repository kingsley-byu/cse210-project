using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to finish): ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        if (numbers.Count > 0)
        {
            int total = 0;
            int largestNumber = numbers[0];
            int smallestPositive = int.MaxValue;

            foreach (int number in numbers)
            { 

                total += number;

                if (number > largestNumber)
                {
                    largestNumber = number;
                }
                if ( number > 0 && number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }

            double average = (double)total / numbers.Count;
            Console.WriteLine("\nResults:");
            Console.WriteLine($"Total is: {total}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest is: {largestNumber}");

            if (smallestPositive != int.MaxValue);
            {
                Console.WriteLine($"Smallest positive number is: {smallestPositive}");

            }
            // to sort the list
            numbers.Sort();
            Console.WriteLine("\nSorted list:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No number were entered.");
        }
        
        
    }
}