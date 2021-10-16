using System;

namespace ConsolePasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordDetails conditions = DataReciver.GetDataFromUser();
            Console.WriteLine(PasswordGenerator.GeneratePassword(conditions));
        }
    }
}
