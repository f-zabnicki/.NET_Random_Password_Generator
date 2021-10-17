using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePasswordGenerator
{
    public static class DataReciver
    {
        public static PasswordDetails GetDataFromUser()
        {
            var lenght = GetLenght();
            var symbols = AskUser("symbols");
            var numbers = AskUser("numbers");
            var lowerCase  = AskUser("lower case characters");
            var upperCase = AskUser("upper case characters");
            return new PasswordDetails(lenght, symbols, numbers, lowerCase, upperCase);

        }
        public static uint GetLenght()
        {
            Console.WriteLine("How long should the password be?");
            uint output;
            try
            {
                output = UInt32.Parse(Console.ReadLine());
                if (output == 0)
                {
                    throw new FormatException("Cannot make password of lenght == 0");
                }
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Cannot convert input value.");
            }
            catch (Exception)
            {
                throw new FormatException("Wrong format of inputted lenght of password");
            }
            return output;
        }
        private static bool AskUser(string question)
        {
            Console.WriteLine($"\nDo you want to include {question}? (y/n)");
            switch (Console.ReadKey().KeyChar)
            {
                case 'y':
                    return true;
                    break;
                case 'n':
                    return false;
                    break;
                default:
                    Console.WriteLine("Wrong key pressed. Try again.");
                    AskUser(question);
                    break;
            }
            throw new NotImplementedException("Not implemented feature");
        }
    }
}
