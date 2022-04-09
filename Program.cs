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
                PiRange();
            }
                


        }
        static float PiRange()
        {

            return 1;
        }
    }
}
