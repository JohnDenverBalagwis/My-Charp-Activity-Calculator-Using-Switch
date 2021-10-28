using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
        }

        static void Method1()
        {
            Console.WriteLine("================================\n");
            Console.Write("ENTER A NUMBER: ");

            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nENTER ANOTHER NUMBER: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("================================\n");
            Console.WriteLine("OPERATORS: \n");
            Console.WriteLine(" +   ADDITION");
            Console.WriteLine(" -   SUBTRACTION");
            Console.WriteLine(" *   MULTIPLICATION");
            Console.WriteLine(" /   DIVISION");
            Console.WriteLine(" ave AVERAGE");
            Console.WriteLine(" %   REMAINDER");
            Console.WriteLine("================================\n");
            Console.Write("ENTER THE OPERATOR: ");
            string myinput = Console.ReadLine();

            switch (myinput)
            {
                case "+":
                    Console.WriteLine("\nTHE SUM IS : " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("\nTHE DIFFERENCE IS : " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("\nTHE PRODUCT IS : " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("\nTHE QUOTIENT IS : " + (num1 / num2));
                    break;
                case "ave":
                    Console
                        .WriteLine("\nTHE AVERAGE IS : " + ((num1 + num2) / 2));
                    break;
                case "%":
                    Console
                        .WriteLine("\nTHE THE REMAINDER IS : " + (num1 % num2));
                    break;
                default:
                    Console.WriteLine("INVALID INPUT...");
                    Console.ReadLine();
                    break;
            }
            Console.WriteLine("================================\n");
            Console.WriteLine("YOU WANT TO TRY AGAIN ? (YES / NO) ");

            string option = Console.ReadLine();

            if (option == "y" || option == "Y")
            {
                Method1();
            }
            else
            {
                Console.WriteLine("_________________________________\n");
                Console.WriteLine("THANK YOU :)");
                Console.WriteLine("_________________________________\n");
                Console.ReadLine();
            }
        }
    }
}