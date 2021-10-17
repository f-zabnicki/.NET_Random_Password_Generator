using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePasswordGenerator
{
    public static class PasswordGenerator
    {
        private const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
        private const string upperCase= "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string numbers = "0123456789";
        private const string symbols = "!@#$%^&";
        public static string GeneratePassword(PasswordDetails conditions)
        {
            string stringPull = "";
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            if (conditions.Numbers) { stringPull += numbers; };
            if (conditions.Symbols) { stringPull += symbols; };
            if (conditions.LowerCaseCharacters) { stringPull += lowerCase; };
            if (conditions.UpperCaseCharacters) { stringPull += upperCase; };
            if (stringPull == "") { throw new FormatException("Cannot create password from nothing"); };
            while ( 0 < conditions.Lenght--) 
            {
                builder.Append(stringPull[random.Next(stringPull.Length)]);
            }
            return builder.ToString();
        }
    }
}
