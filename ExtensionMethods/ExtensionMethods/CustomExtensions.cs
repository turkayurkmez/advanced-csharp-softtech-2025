using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class CustomExtensions
    {
        public static int GetSquare(this int number) => number * number;

        public static string NextLetter(this Random random, bool isLower=false)
        {
            //65-90 97-122

            int charValue = isLower ? random.Next(97, 123) : random.Next(65, 91);        
            string letter = ((char)charValue).ToString();
            return letter;

          
        }

        public static string NextPassword(this Random random, int length = 6) {

            string password = string.Empty;
            for (int i = 0; i < length; i++)
            {
                var isLower = Convert.ToBoolean(random.Next(0, 2));
                password += random.NextLetter(isLower);
            }

            return password;
          

        }
    }
}
