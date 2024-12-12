using System;
using System.Text;

namespace NewExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string encrypted = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] arr = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = arr[0];
                if (command == "Move")
                {
                    int count = int.Parse(arr[1]);
                    string substring = encrypted.Substring(0, count);
                    encrypted = encrypted.Remove(0, count);
                    encrypted += substring;
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(arr[1]);
                    string value = arr[2];
                    encrypted = encrypted.Insert(index, value);
                }
                else if (command == "ChangeAll")
                {
                    string substring = arr[1];
                    string replacement = arr[2];
                    encrypted = encrypted.Replace(substring, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {encrypted}");
        }
    }
}
