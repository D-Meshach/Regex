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
            //UC3 Valid Email Address
            Console.WriteLine("Email=abc@bl.co" + " Match=" + RegexRegistration.ValidEmail("abc@bl.co"));
            //UC4 Mobile pre format
            Console.WriteLine("Mobile Format=91 9679374654 Match=" + RegexRegistration.ValidMobileFormat("91 9679374654"));

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
        public static bool ValidEmail(String email)
        {
            String RegEx = "^[a-z]{3}([.][a-z]+)?[@][a-z]{2}[.][a-z]{2}([.][a-z]{2})?$";
            return Regex.IsMatch(email, RegEx);
        }
        public static bool ValidMobileFormat(String mobile)
        {
            String RegEx = "^[1-9]{2}[ ][1-9]{10,10}$";
            return Regex.IsMatch(mobile, RegEx);
        }



    }

}
