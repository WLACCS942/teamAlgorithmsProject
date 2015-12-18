using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class recursiveFactorial
    {
        static void Main(string[] args)
        {
            //Variables
            string input;
            int result;
            int number = 0;
            bool isNumeric;

            Console.WriteLine("FACTORIAL CALCULATOR. TYPE 'quit' to exit.");

            do
            {
                Console.WriteLine("Enter a number: ");
                input = Console.ReadLine();
                input = input.ToLower();
                isNumeric = int.TryParse(input, out number);
                if (isNumeric && number > 0)
                {
                    result = factorial(Int32.Parse(input));
                    Console.WriteLine("{0}! = {1}", input, result);
                }
                else if(number < 0)
                {
                    Console.WriteLine("Value must be positive!");
                }
               
             }while (input != "quit");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

       static int factorial(int n)
        {
            if(n == 0)
            {
                return 1;
            } else
            {
                return n * factorial(n - 1);
            }
        }
    }
}
