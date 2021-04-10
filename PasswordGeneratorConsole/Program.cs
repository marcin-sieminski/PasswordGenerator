using System;
using PasswordGenerator.Common;

namespace PasswordGeneratorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var pass = new PasswordGeneratorModel{PasswordLength = 10};
            do
            {
                pass.GeneratePassword();
                Console.WriteLine(pass.Password);
                Console.ReadKey();
            } while (true);
            
        }
    }
}
