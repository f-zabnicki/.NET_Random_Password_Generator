using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePasswordGenerator
{
    class PasswordDetails
    {
        public int Lenght { get; set; }
        public bool Symbols { get; set; }
        public bool Numbers { get; set; }
        public bool LowerCaseCharacters { get; set; }
        public bool UpperCaseCharacters { get; set; }
        public PasswordDetails(int lenght, bool symbols, bool numbers, bool lowerCase, bool upperCase)
        {
            Lenght = lenght;
            Symbols = symbols;
            Numbers = numbers;
            LowerCaseCharacters = lowerCase;
            UpperCaseCharacters = upperCase;
        }
    }
}
