using System;
using System.Runtime.Remoting.Messaging;

namespace PasswordGenerator
{
    public static class Password
    {
        private static string pass = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private static Random Rdpass = new Random();
        public static string Generate(int length)
        {
            if (length > pass.Length)
            {
                throw new ArgumentOutOfRangeException("No much characters");
            }

            int seed = Rdpass.Next();
            Random random = new Random(seed);

            string password = string.Empty;
            for (int i = 0; i < length; i++)
            {
                password += pass[Rdpass.Next(0, pass.Length)];
            }
            return password;
        }
    }
}
