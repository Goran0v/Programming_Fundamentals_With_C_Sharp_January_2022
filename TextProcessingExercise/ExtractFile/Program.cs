using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string fileInfo = text.Substring(text.LastIndexOf('\\') + 1);
            string[] nameAndFormat = fileInfo.Split('.');
            string name = nameAndFormat[0];
            string format = nameAndFormat[1];
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {format}");
        }
    }
}