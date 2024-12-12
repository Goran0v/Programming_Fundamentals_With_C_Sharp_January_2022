using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split().ToArray();
            string[] secondLine = Console.ReadLine().Split().ToArray();
            string[] commonElements = new string[firstLine.Length];
            int index = 0;

            for (int i = 0; i < secondLine.Length; i++)
            {
                
                for (int j = 0; j < firstLine.Length; j++)
                {
                    if (secondLine[i] == firstLine[j])
                    {
                        commonElements[index] = secondLine[i];
                        index++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", commonElements));
        }
    }
}
