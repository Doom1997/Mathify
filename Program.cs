using System;


namespace Mathify
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize();
        }



        static void Initialize()
        {

            Console.WriteLine("Welcome to Mathify! Please select your desired function");
            Console.WriteLine("1: Find Pi to the Nth Digit");
            Console.WriteLine("2: Find e to the Nth Digit");
            Console.WriteLine("3: Find Fibonnaci Sequence to a given number");
            Console.WriteLine("4: Find all Prime Factors to a given number");
            Console.WriteLine("5: Find Prime Numbers until the user decides to stop");
            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                do
                {
                    CalculatePI();
                    Console.WriteLine("Calculate again? (y/n)");
                } while (Console.ReadLine() != "n");

                
            }

           

        }
        static void CalculatePI()
        {
            double pi = Math.Atan(1) * 4;
            Console.WriteLine("Enter the number of digits you want to find in Pi? (Max: 15)");

            string input = Console.ReadLine();
            int digit;
            if (int.TryParse(input, out digit))
            {
                try
                {
                    double result = Math.Round(pi, digit);
                    Console.WriteLine("Pi to {0} digits is {1}.", digit, result);
                }
                catch
                {
                    Console.WriteLine("The max digits is 15! Try again.");
                }
                
            }
            
        }
    }
}
