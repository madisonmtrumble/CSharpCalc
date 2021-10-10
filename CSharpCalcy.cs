using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;

                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.Write("Type a number, press enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;

                while(!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Not valid input. Enter an integer value: ");

                    numInput1 = Console.ReadLine();
                }

                Console.Write("Type another number, then press enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Not valid input. Enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }

                Console.WriteLine("Choose an operator:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("Your choice: ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This will result in error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oops, an error has occurred.\n - Details: " + e.Message);
                }

                Console.WriteLine("-----------------------\n");

                Console.Write("Press 'n' and enter to close the app, or any other key to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
                

            }
            return;
        }
    }
    
}
