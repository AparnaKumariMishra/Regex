using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserCase3
{
    internal class UC3Email
    {
        public static string Email = "^[A-Z]{3}[.][a-z]{3}@[a-z]{2}[.][a-z]{2}$";//YAS.raj@co.in
 
        public static bool validate(string Word )
        {
            return Regex.IsMatch(Word, Email);
        }

    }
}
