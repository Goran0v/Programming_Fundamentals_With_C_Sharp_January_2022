using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            bigNumber = bigNumber.TrimStart(new char[] { '0' });
            string smallNumber = Console.ReadLine();
            List<string> reallyBigNumber = new List<string>();
            int numToAdd = 0;

            if (bigNumber == "0" || smallNumber == "0")
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = bigNumber.Length - 1; i >= 0; i--)
                {
                    int equation = ((bigNumber[i] - '0') * int.Parse(smallNumber)) + numToAdd;
                    string version = equation.ToString();
                    numToAdd = version[0] - '0';
                    for (int j = version.Length - 1; j >= 0; j--)
                    {
                        reallyBigNumber.Add(version[j].ToString());
                        if (i != 0)
                        {
                            break;
                        }
                    }
                    if (equation < 10)
                    {
                        numToAdd = 0;
                    }
                }

                reallyBigNumber.Reverse();
                Console.WriteLine(string.Join("", reallyBigNumber));
            }
        }
    }
}
