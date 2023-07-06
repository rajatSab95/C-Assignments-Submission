using System;

class Sample
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Divide by zero");
            Console.WriteLine("2. Index out of range");
            Console.WriteLine("3. Format exception");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DivideByZero();
                    break;
                case "2":
                    IndexOutOfRange();
                    break;
                case "3":
                    FormatException();
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void DivideByZero()
    {
        try
        {
            int numerator = 10;
            int denominator = 0;
            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }
    }

    static void IndexOutOfRange()
    {
        try
        {
            int[] numbers = { 1, 2, 3 };
            int index = 10;
            int value = numbers[index];
            Console.WriteLine("Value: " + value);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }
    }

    static void FormatException()
    {
        try
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            Console.WriteLine("Number: " + number);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }
    }
}
