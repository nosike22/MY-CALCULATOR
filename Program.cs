using System;

namespace Proper_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("~~~~~~~~~~~");

            Console.WriteLine("Choose which operation you wish to carry");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplication");
           

            Console.WriteLine("Enter your desired option");
            int x = int.Parse(Console.ReadLine());


            if (x == 1)
            {
                Console.WriteLine("n\n(You have chosen addition)");
                Console.WriteLine("Enter the first number");
                Int64 a = Int64.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                Int64 b = Int64.Parse(Console.ReadLine());

                Int64 sum = a + b;

                Console.WriteLine("The sum of {0} and {1} is {2}", a, b, sum);
            }

            else if( x == 2)
            {
                Console.WriteLine("n\n(You have chosen subtraction");
                Console.WriteLine("Enter the first number");
                Int64 a = Int64.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Second Number");
                Int64 b = Int64.Parse(Console.ReadLine());

                Int64 difference = a - b;

                Console.WriteLine("The difference between {0} and {1} is {2}", a, b, difference);

            }

            else if(x == 3)
            {
                Console.WriteLine("n\n(You have chosen division");
                Console.WriteLine("Enter the first number");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                double b = double.Parse(Console.ReadLine());

                double quotient = a / b;

                Console.WriteLine("The quotient of {0} and {1} is {2}", a, b, quotient);


            }

            else if( x == 4)
            {
                Console.WriteLine("n\n(You have chosen subtraction");
                Console.WriteLine("Enter the first number");
                Int64 a = Int64.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Second Number");
                Int64 b = Int64.Parse(Console.ReadLine());

                Int64 Product = a * b;

                Console.WriteLine("The Product of {0} and {1} is {2}", a, b, Product);


            }
            else 
            {
                Console.WriteLine("RETYPE WEREY");
            }













        }
    }
}
