using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex1
{
    public class UC1FirstUser
    {
          public static string Firstdigit = "^[A-Z]{1}[a-z]{2}$";
        public bool validate_First(string Firstname)
        {
          return Regex.IsMatch(Firstname, Firstdigit);
        }
        //public static string REGEX_FIRSTNAME = "^[A-Z]{1}[a-z]{3}$";
        //public bool ValidateFIRSTNAME(string firstname)
        //{
          //  return Regex.IsMatch(firstname, REGEX_FIRSTNAME);
        //}
    }
}
