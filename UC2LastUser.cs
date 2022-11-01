using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC2LastUser
{
    internal class UC2LastUser
    {
        public static string Lastdigit = "^[A-Z][A-za-z]{3}$";
        public bool validate_Last(string Lastname)
        {
            return Regex.IsMatch(Lastname, Lastdigit);
        }
    }
}

