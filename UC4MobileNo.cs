using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserCase4
{
    internal class UC4MobileNo
    {
        public static string MobileNo = "^[9][1][\\s]?[0-9]{10}$";
        public static bool validate(string Number)
        {
            return Regex.IsMatch(Number, MobileNo);
        }
    }
}
