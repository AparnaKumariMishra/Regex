using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex1
{
   public class program
    {
        public static void Main(string[] args)
        {
             UC1FirstUser pattern = new UC1FirstUser();
            Console.WriteLine(pattern.validate_First("Try"));
            //Console.WriteLine("Please Enter Name");
            //string pattern = Console.ReadLine();
            //UC1FirstUser obj = new UC1FirstUser();
            //bool val = obj.ValidateFirstName(pattern);
            //if (val)
              //  Console.WriteLine("Pattern Matched");
            //else
             //   Console.WriteLine("Pattern Not Matched");
            //Console.WriteLine("---------------");

        }
    }
}