using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regex_demo
{
    internal class Registration
    {
        public Registration()
        {
            //UC1 Valid First Name
            Console.WriteLine("Username=Mahesh"+" Match="+RegexRegistration.ValidUser("Mahesh"));
            //UC2 valid Last Name
            Console.WriteLine("Username=ramesH" + " Match=" + RegexRegistration.ValidLastName("ramesH"));

        }
    }
    public class RegexRegistration
    {

        
        public  static bool ValidUser(String name) 
        {
            String RegEx = "^[A-Z][A-Za-z]{3,}$";
            return Regex.IsMatch(name, RegEx);
        }
        public static bool ValidLastName(String name)
        {
            String RegEx = "^[A-Za-z]{2,}[A-Z]$";
            return Regex.IsMatch(name, RegEx);

        }




    }

}
