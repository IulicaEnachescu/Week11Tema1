using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatin
{
    public class GoatLatin
    {
        public string GoatLatinString(string str)
        {   if (string.IsNullOrEmpty(str))
                throw new ArgumentNullException("Empty or null string");
            else
            {
                string[] words = str.Split(' ');
                StringBuilder goatLatin = new StringBuilder();
                for (int i = 0; i < words.Length; i++)
                {
                    //string numericPhone = new String(phone.Where(Char.IsDigit).ToArray());

                    if (StartWithVowel(words[i]))
                    {
                        goatLatin.Append(words[i]);
                       
                    }
                    
                    else
                    {
                        goatLatin.Append(words[i].Substring(1));
                        goatLatin.Append(words[i][0]);
                    }
                    goatLatin.Append("ma");
                    for (int j = 0; j <= i; j++)
                    {
                        goatLatin.Append("a");
                    }
                    if (i < words.Length - 1) goatLatin.Append(" ");
                }
                
                return goatLatin.ToString();
            }
        }
        private static bool StartWithVowel(string l)
        {
            if (l.StartsWith("A")) return true;
            if (l.StartsWith("a")) return true;
            if (l.StartsWith("E")) return true;
            if (l.StartsWith("e")) return true;
            if(l.StartsWith("I")) return true;
            if(l.StartsWith("i")) return true;
            if (l.StartsWith("O")) return true;
            if (l.StartsWith("o")) return true;
            if (l.StartsWith("U")) return true;
            if (l.StartsWith("u")) return true;
            return false;

        }
    }
}
