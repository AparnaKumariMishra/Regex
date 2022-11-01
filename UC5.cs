using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserCase5
{
    internal class UC5
    {
        public static string password = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        public static bool validate(string value)
        {
            return Regex.IsMatch(value, password);
        }
    }
}
