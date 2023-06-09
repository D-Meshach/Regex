﻿using System;
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
            //UC5  Password rume min eight char
            Console.WriteLine("PasswordEightCharacter=sdkjSAD1 Match=" + RegexRegistration.PasswordEightChar("sdkjSAD1"));
            //UC6 Password One Upper Case
            Console.WriteLine("PasswordUpperCase=sdAZoaagjk Match=" + RegexRegistration.PasswordUpperCase("sdAZoaagjk"));
            //UC7 Password One Numberic
            Console.WriteLine("PasswordOneNumeric=saASk1jlo Match=" + RegexRegistration.PasswordOneNumeric("saASk1jlo"));
            //UC8  One special Character 
            Console.WriteLine("PasswordOneSpecialChar=saA?Skjlo" + RegexRegistration.PasswordOneSpecialChar("saA?Skjlo"));
            //UC9 AllEmailCharType
            Console.WriteLine("All Email Type Test------");
            Console.WriteLine("Valid Email=abc@yahoo.com Match=" + RegexRegistration.ValidEmails("abc@yahoo.com"));
            Console.WriteLine("Valid Email=abc-100@yahoo.com, Match=" + RegexRegistration.ValidEmails("abc-100@yahoo.com"));
            Console.WriteLine("Valid Email=abc.100@yahoo.com Match=" + RegexRegistration.ValidEmails("abc.100@yahoo.com"));
            Console.WriteLine("Valid Email=abc111@abc.com, Match=" + RegexRegistration.ValidEmails("abc111@abc.com"));
            Console.WriteLine("Valid Email=abc-100@abc.net Match=" + RegexRegistration.ValidEmails("abc-100@abc.net"));
            Console.WriteLine("Valid Email=abc.100@abc.com.au Match=" + RegexRegistration.ValidEmails("abc.100@abc.com.au"));
            Console.WriteLine("Valid Email=abc@1.com Match=" + RegexRegistration.ValidEmails("abc@1.com"));
            Console.WriteLine("Valid Email=abc@gmail.com.com Match=" + RegexRegistration.ValidEmails("abc@gmail.com.com"));
            Console.WriteLine("Valid Email=abc+100@gmail.com Match=" + RegexRegistration.ValidEmails("abc+100@gmail.com"));





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
        public static bool PasswordEightChar(String Password)
        {
            String RegEx = "^[1-9A-Za-z]{8,}$";
            return Regex.IsMatch(Password, RegEx);
        }
        public static bool PasswordUpperCase(String Password)
        {
            String RegEx = "^.*[A-Z]{2}[a-z]{8}$";
            return Regex.IsMatch(Password, RegEx);
        }
        public static bool PasswordOneNumeric(String number)
        {
            String RegEx = "^.*([0-9]{1})[A-Za-z]+$";
            return Regex.IsMatch(number, RegEx);
        }
        public static bool PasswordOneSpecialChar(String password)
        {
            // String RegEx = "^.*([?.!@#$%^&*\\()/-'\"]{1})[A-Za-z]+$";
            String RegEx = "^.*[<?.!@#$%&*\\()'\"/->]{1}[A-Za-z]+$";
            return Regex.IsMatch(password, RegEx);
        }
        public static bool ValidEmails(String email)
        {
            //String RegEx = "^[a-z]{3}[@][a-z]+[.][a-z]{3}$";
            //3String RegEx = "^[a-z]{3}[.-][0-9]{3}[@][a-z]+[.][a-z]{3}$";
            String RegEx = "^[a-z]{3}([+.-])?([0-9]{3})?[@][a-z0-9]+[.][a-z]{3}([.][a-z]{2,})?$";
            return Regex.IsMatch(email, RegEx);
        }




    }

}
