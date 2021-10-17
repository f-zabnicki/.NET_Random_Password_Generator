using System;
using System.Reflection;

namespace ConsolePasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            Console.WriteLine($"ver.{version}");
            PasswordDetails conditions = DataReciver.GetDataFromUser();
            Console.WriteLine(PasswordGenerator.GeneratePassword(conditions));
            Console.ReadLine();
        }
    }
}
