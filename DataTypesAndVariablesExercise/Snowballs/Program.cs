using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            ushort snowballSnow = 0;
            ushort snowballTime = 0;
            byte snowballQuality = 0;
            BigInteger snowballValue = 0;
            BigInteger maxValue = 0;
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;

            for (int i = 1; i <= n; i++)
            {
                snowballSnow = ushort.Parse(Console.ReadLine());
                snowballTime = ushort.Parse(Console.ReadLine());
                snowballQuality = byte.Parse(Console.ReadLine());
                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > maxValue)
                {
                    maxValue = snowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {maxValue} ({bestSnowballQuality})");
        }
    }
}
