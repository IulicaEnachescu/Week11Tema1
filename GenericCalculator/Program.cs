using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                string action = Meniu();
                Console.WriteLine("Enter 1st input");
                string input1 = Console.ReadLine();
                Console.WriteLine("Enter 2nd input");
                string input2 = Console.ReadLine();

               double rez= MathCalculator(action, input1, input2);

            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }


            Console.ReadKey();
        }

        private static double MathCalculator(string action, string input1, string input2)
        {//convert string to number int or double
            double rez;
            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2)) throw
                                    new ArgumentNullException();
            if (input1.Contains(".") || input2.Contains("."))
            {
                double number1 = double.Parse(input1);
                double number2 = double.Parse(input2);
                Console.WriteLine("The result is");
                rez = Calculator.Calculate(action, number1, number2);
                Console.WriteLine(rez);

            }
            else
            {
                int number1 = int.Parse(input1);
                int number2 = int.Parse(input2);
                Console.WriteLine("The result is");
                rez = Calculator.Calculate(action, number1, number2);
                Console.WriteLine(rez);
            }
            return rez;
        }

        public static string Meniu()
        {//choose math operation
           string action=null;
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Addition : a");
            Console.WriteLine("Substraction : s");
            Console.WriteLine("Multiplication : m");
            Console.WriteLine("Division : d");
            bool cond = false;
            while (cond == false)
            {
                action = Console.ReadLine();
                if (action== "a"|| action == "s" || action == "m" || action == "d") cond = true;
                else
                    Console.WriteLine("Enter the action to be performed");
            }
            return action;
        }
    }
}
