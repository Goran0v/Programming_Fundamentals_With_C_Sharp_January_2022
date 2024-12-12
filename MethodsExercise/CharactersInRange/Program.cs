using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            Console.WriteLine($"{GetChars(start, end)} ");
        }
        static string GetChars(char start, char end)
        {
            int counter = 0;
            if (start <= end)
            {
                char[] current = new char[(int)end - (int)start - 1];
                for (int i = (int)start + 1; i < (int)end; i++)
                {
                    char curr = (char)i;
                    current[counter] = curr;
                    counter++;
                }
                string chars = string.Join(" ", current);
                return chars;
            }
            else
            {
                char[] current = new char[(int)start - (int)end - 1];
                for (int i = (int)end + 1; i < (int)start; i++)
                {
                    char curr = (char)i;
                    current[counter] = curr;
                    counter++;
                }
                string chars = string.Join(" ", current);
                return chars;
            }
        }
    }
}
