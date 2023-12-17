using System;
using System.Collections.Generic;
using PasswordGenerator;

namespace TestPasswordGenerator
{
    class Program
    {
        static void Main()
        {
            int ilgis = 20;
            int masyvai = 30;
            string[] passwords = new string[masyvai];

            for (int i = 0; i < masyvai; i++)
            {
                passwords[i] = Password.Generate(ilgis);
            }

            foreach (string password in passwords)
            {
                Console.WriteLine("\t {0}", password);
            }

            Console.Read();
        }
    }
}
