using System;
using System.Collections.Generic;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello foreign");
            listNumbers();
        }

        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            int c = 1;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greaten than 10!");
                Console.WriteLine("And the first number is equal the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10!");
                Console.WriteLine("Or the first number is not equal to the second number");
            }
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");

            }
        }
        static void ExploreLoops()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            int count = 10;
            do
            {
                Console.WriteLine($"Hello Foreign! The counter is {count}");
                count++;

            } while (count < 10);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello Everyone");
            }

        }
        static void ExploreNested()
        {
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"Row: {row} Column: {column}");
                }
            }
        }
        static void SumOfIntegers()
        {
            int counter = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    counter = counter + i;
                }
            }
            Console.WriteLine($"The sum of the numbers divisible by 3 from 1 to 20 is {counter}");
        }

        static void listTutorial()
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            // Or
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!");
            }

            names.Add("Gabe");
            names.Add("James");
            names.Remove("<name>");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"This list has {names.Count} people on it");

            var index = names.IndexOf("Gabe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"Found {names[index]} at {index}");
            }
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
        }
        static void listNumbers()
        {
            var fibonacciNumber = new List<int> { 1, 1 };
            var previous = fibonacciNumber[fibonacciNumber.Count - 1];
            var previous2 = fibonacciNumber[fibonacciNumber.Count - 2];
            for (int i = 0; i < 18; i++)
            {
                previous = fibonacciNumber[fibonacciNumber.Count - 1];
                previous2 = fibonacciNumber[fibonacciNumber.Count - 2];
                fibonacciNumber.Add(previous + previous2);
            }
            foreach (var n in fibonacciNumber)
            {
                Console.WriteLine(n);
            }
        }
    
    }
}
