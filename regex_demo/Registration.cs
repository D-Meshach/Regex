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
            
        }
    }
    public class RegexRegistration
    {

        
        public  static bool ValidUser(String name) {
            String RegEx = "^[A-Z][A-Za-z]{3,}$";
            
            return Regex.IsMatch(name, RegEx);

        }
      
      
    
    }

}
