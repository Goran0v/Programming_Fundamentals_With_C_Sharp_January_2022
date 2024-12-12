using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(' ');
                string cmdType = cmdArgs[0];
                if (cmdType == "exchange")
                {
                    int exchangeIndex = int.Parse(cmdArgs[1]);

                    if (exchangeIndex < 0 || exchangeIndex >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers = ExchangeArrayParts(numbers, exchangeIndex);
                }
                else if (cmdType == "max" || cmdType == "min")
                {
                    string oddOreven = cmdArgs[1];

                    int index;
                    if (cmdType == "max")
                    {
                        index = MaxElementOfTypeIndex(numbers, oddOreven);
                    }
                    else
                    {
                        index = MinElementOfTypeIndex(numbers, oddOreven);
                    }

                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }
                else if (cmdType == "first" || cmdType == "last")
                {
                    int count = int.Parse(cmdArgs[1]);
                    string oddOrEven = cmdArgs[2];

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (cmdType == "first")
                    {
                        PrintFirstElementsOfType(numbers, count, oddOrEven);
                    }
                    else
                    {
                        PrintLastElementsOfType(numbers, count, oddOrEven);
                    }
                }
            }

            Console.WriteLine(ArrayToStringFormat(numbers, numbers.Length));
        }
        static int[] ExchangeArrayParts(int[] numbers, int index)
        {
            int[] exchangedNumbers = new int[numbers.Length];
            int exchangedNumbersIndex = 0;

            for (int i = index + 1; i < numbers.Length; i++)
            {
                exchangedNumbers[exchangedNumbersIndex] = numbers[i];
                exchangedNumbersIndex++;
            }

            for (int i = 0; i <= index; i++)
            {
                exchangedNumbers[exchangedNumbersIndex] = numbers[i];
                exchangedNumbersIndex++;
            }

            return exchangedNumbers;
        }
        static int MaxElementOfTypeIndex(int[] numbers, string oddOrEven)
        {
            int index = -1;
            int maxValue = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if (oddOrEven == "even")
                {
                    if (currentNum % 2 == 0 && currentNum >= maxValue)
                    {
                        maxValue = currentNum;
                        index = i;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currentNum % 2 != 0 && currentNum >= maxValue)
                    {
                        maxValue = currentNum;
                        index = i;
                    }
                }
            }

            return index;
        }
        static int MinElementOfTypeIndex(int[] numbers, string oddOrEven)
        {
            int index = -1;
            int minValue = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if (oddOrEven == "even")
                {
                    if (currentNum % 2 == 0 && currentNum <= minValue)
                    {
                        minValue = currentNum;
                        index = i;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currentNum % 2 != 0 && currentNum <= minValue)
                    {
                        minValue = currentNum;
                        index = i;
                    }
                }
            }

            return index;
        }
        static void PrintFirstElementsOfType(int[] numbers, int count, string oddOrEven)
        {
            int[] firstElements = new int[count];
            int firstelementsIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];

                if (oddOrEven == "even")
                {
                    if (currNum % 2 == 0 && firstelementsIndex < count)
                    {
                        firstElements[firstelementsIndex] = currNum;
                        firstelementsIndex++;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currNum % 2 != 0 && firstelementsIndex < count)
                    {
                        firstElements[firstelementsIndex] = currNum;
                        firstelementsIndex++;
                    }
                }
            }

            Console.WriteLine(ArrayToStringFormat(firstElements, firstelementsIndex));
        }
        static void PrintLastElementsOfType(int[] numbers, int count, string oddOrEven)
        {
            int[] lastElements = new int[count];
            int lastElementsIndex = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currNum = numbers[i];

                if (oddOrEven == "even")
                {
                    if (currNum % 2 == 0 && lastElementsIndex < count)
                    {
                        lastElements[lastElementsIndex] = currNum;
                        lastElementsIndex++;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currNum % 2 != 0 && lastElementsIndex < count)
                    {
                        lastElements[lastElementsIndex] = currNum;
                        lastElementsIndex++;
                    }
                }
            }

            int[] reverseArray = new int[lastElementsIndex];
            int reverseArrayIndex = 0;
            for (int i = lastElementsIndex - 1; i >= 0; i--)
            {
                reverseArray[reverseArrayIndex] = lastElements[i];
                reverseArrayIndex++;
            }

            Console.WriteLine(ArrayToStringFormat(reverseArray, reverseArrayIndex));
        }
        static string ArrayToStringFormat(int[] arr, int elementsCount)
        {
            string output = string.Empty;
            output += "[";

            for (int i = 0; i < elementsCount; i++)
            {
                if (i == elementsCount - 1)
                {
                    output += $"{arr[i]}";
                }
                else
                {
                    output += $"{arr[i]}, ";
                }
            }

            output += "]";

            return output;
        }
    }
}
