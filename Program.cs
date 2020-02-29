using System;

namespace Deliverable_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jordan Simmons");
            //Console.WriteLine("Enter your first number: ");
            
            
            int FirstNumber;

            Console.Write("Enter your first number:");

            while (!Int32.TryParse(Console.ReadLine(), out FirstNumber))
            {
                Console.Clear();
                Console.WriteLine("Invalid data input");
                Console.WriteLine("Please enter a number");
            }
            
            

            int SecondNumber;

            Console.Write("Enter your second number:");

            while (!Int32.TryParse(Console.ReadLine(), out SecondNumber))
            {
                
                Console.WriteLine("Invalid data input");
                Console.WriteLine("Please enter a number");
            }
            



            Console.WriteLine("Which function would you like to use?");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtration");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");

            string Function;
            int FunNum;
            int solution;

            Function = Console.ReadLine();
            Console.WriteLine("You entered: " + Function);

            if (!Int32.TryParse(Function, out FunNum))
            {
                Console.WriteLine("  Invalid data input. Please start again.");
            }
            else if ((FunNum < 1) || (FunNum > 4))
            {
                Console.WriteLine("  The number you put was out of range: Please start again and " +
                    "enter either 1, 2, 3, or 4 for your function selection.");
            }
            else if (FunNum == 1)
            {
                solution = FirstNumber + SecondNumber;
                Console.WriteLine("The sum of your numbers is: " + solution);
            }
            else if (FunNum == 2)
            {
                solution = FirstNumber - SecondNumber;
                Console.WriteLine("The difference between your numbers is: " + solution);
            }
            else if (FunNum == 3)
            {
                solution = FirstNumber * SecondNumber;
                Console.WriteLine("The product of your numbers is: " + solution);
            }
            else if (FunNum == 4)
            {
                if (SecondNumber == 0)
                {
                    Console.WriteLine("You cannot divide by 0. Please try again and chose " +
                        "a second number that is not 0.");
                }
                else
                {
                    solution = FirstNumber / SecondNumber;
                    Console.WriteLine("The quotient of your numbers is: " + solution);
                }
                    
            }
        }
    }
}
