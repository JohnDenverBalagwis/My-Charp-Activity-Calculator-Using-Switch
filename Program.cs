using System;

namespace SwitchCaseConstructCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Method1();
        }

        private static void Method1()
        {
            Console.Clear();
            Console.WriteLine("=================================\n");
            Console.Write("ENTER A NUMBER: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nENTER ANOTHER NUMBER: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("OPERATORS: \n");
            Console.WriteLine(" +\t\tADDITION");
            Console.WriteLine(" -\t\tSUBTRACTION");
            Console.WriteLine(" *\t\tMULTIPLICATION");
            Console.WriteLine(" /\t\tDIVISION");
            Console.WriteLine(" ave\t\tAVERAGE");
            Console.WriteLine(" %\t\tREMAINDER");
            Console.WriteLine("=================================\n");
            Console.Write("ENTER THE OPERATOR: ");
            switch (Console.ReadLine())
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
                    Console.WriteLine("\nTHE AVERAGE IS : " + ((num1 + num2) / 2));
                    break;

                case "%":
                    Console.WriteLine("\nTHE THE REMAINDER IS : " + (num1 % num2));
                    break;

                default:
                    Console.WriteLine("INVALID INPUT...");
                    Console.ReadLine();
                    break;
            }
            Console.WriteLine("\n=================================\n");
            Console.WriteLine("YOU WANT TO TRY AGAIN ? (Y / N) ");
            string choice = Console.ReadLine();
            if ((choice == "y") || (choice == "Y"))
            {
                Method1();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("\tTHANK YOU :)");
                Console.WriteLine("=================================\n");
                Console.ReadKey();
            }
        }
    }
}
