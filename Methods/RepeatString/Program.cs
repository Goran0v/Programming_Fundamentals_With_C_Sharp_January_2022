using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string template = Console.ReadLine();
            int repeatTimes = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(template, repeatTimes));
        }
        static string RepeatString(string template, int numOfRepeats)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 1; i <= numOfRepeats; i++)
            {
                stringBuilder.Append(template);
            }
            return stringBuilder.ToString();
        }
    }
}
