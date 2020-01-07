using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GoatLatin rez = new GoatLatin();
                string s = "I speak Goat Latin";
                Console.WriteLine("I speak Goat Latin");
                Console.WriteLine(rez.GoatLatinString(s));
                Console.ReadLine();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
