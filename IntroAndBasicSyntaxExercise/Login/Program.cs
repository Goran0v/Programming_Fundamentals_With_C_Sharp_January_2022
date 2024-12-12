using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            string newPassword = string.Empty;
            int br = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            for (int i = 1; i <= 4; i++)
            {
                newPassword = Console.ReadLine();
                br++;
                if (newPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (br == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
