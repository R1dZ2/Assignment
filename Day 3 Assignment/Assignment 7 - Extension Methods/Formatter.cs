using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_7___Extension_Methods
{
    public static class Formatter
    {
        static Formatter()
        {
            
        }

        public static string CapitalizeLetter(this string value)
        {
            string[] splittedProduct = value.Split(' ');
            var sb = new StringBuilder();
            char[] splittedProductChars;
            foreach (String s in splittedProduct)
            {
                splittedProductChars = s.ToCharArray();
                if (splittedProductChars.Length > 0)
                {
                    splittedProductChars[0] = new String(splittedProductChars[0], 1).ToUpper().ToCharArray()[0];

                    for (int i = 1; i < splittedProductChars.Length; i++)
                    {
                        splittedProductChars[i] = new String(splittedProductChars[i], 1).ToLower().ToCharArray()[0];
                    }
                }
                sb.Append(new String(splittedProductChars));
                sb.Append(" ");
            }
            return sb.ToString().TrimEnd();
        }

        public static string UrlEncode(this string input) 
        {
            return input.Replace(" ", "%20");
        }
    }
}
