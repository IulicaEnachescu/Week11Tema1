using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericCalculator
{
    public static class Calculator
    {
        public static double Calculate <T> (string action, T number1, T number2)
        {
            double result =0;
            switch (action)
            {
                case "a":
                    {
                        result = Convert.ToDouble(Add(number1, number2));
                        break;
                    }
                case "s":
                    {
                        result = Convert.ToDouble(Sub(number1, number2));
                        break;
                    }
                case "m":
                    {
                        result = Convert.ToDouble(Mult(number1, number2));
                        break;
                    }
                case "d":
                    {   
                        result = Div(number1, number2);
                        
                        break;
                    }
                default:
                    break;
            }
            
            return System.Math.Round(result, 3); 

        }
        
    
        private static T Add<T>(T x, T y)
        {
            if (typeof(T).IsPrimitive)
            {
                var rez = (dynamic)x + (dynamic)y;
                return (T)rez;
            }
            else

                throw new ArgumentException($"Exception: Non-number elements in Add function: {typeof(T)}");
        }

        private static T Sub<T>(T x, T y)
        {
            if (typeof(T).IsPrimitive)
            {
                var rez = (dynamic)x - (dynamic)y;
                return (T)rez;
            }
            else
                throw new ArgumentException($"Exception: Non-number element in Substract function: {typeof(T)}");
        }

        private static T Mult<T>(T x, T y)
        {
            if (typeof(T).IsPrimitive)
            {
                var rez = (dynamic)x * (dynamic)y;
                return (T)rez;
            }
            else
                throw new ArgumentException($"Exception: Non-number element in Multiplication function: {typeof(T)}");
        }
        private static double Div<T>(T x, T y)
        {
            if (typeof(T).IsPrimitive)
            {
                double rez;
                if ((dynamic)x == 0 && (dynamic)x == 0) throw new InvalidOperationException("Invalid operation " +
                    "exception: both arguments are 0 Exception");
                if ((dynamic)y == 0) throw new DivideByZeroException("Is not possible " +
                    "to divide a number to zero Exception");
                else
                {
                    if (x is int)
                    {
                        rez = Convert.ToDouble(x) / Convert.ToDouble(y);
                       

                    }
                    else
                    {
                        rez = (dynamic)x / (dynamic)y;
                    }
                    return (double)rez;
                }
            }
            else
                throw new ArgumentException($"Exception: Non-number element in Multiplication function: {typeof(T)}");
        }

    }
}
