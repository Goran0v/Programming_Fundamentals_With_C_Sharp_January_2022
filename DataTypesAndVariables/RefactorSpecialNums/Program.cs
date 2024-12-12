using System;

namespace RefactorSpecialNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int ch = 1; ch <= n; ch++)
            {
                
                int sum = 0;
                int num = ch;
                bool special = false;
                
                while (num != 0)
                {
                    int currentNum = num % 10;
                    num /= 10;
                    sum += currentNum;
                }
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", ch, special);
            }

        }
    }
}
