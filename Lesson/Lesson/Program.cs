using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Net.Http.Headers;

namespace Lesson
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = ReadArray();

            Console.WriteLine($"Min: {numbers[FindMin(numbers)]}");
            Console.WriteLine($"Max: {numbers[FindMax(numbers)]}");
        }

        static int FindMin(int[] numbers)
        {
            int minIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        static int FindMax(int[] numbers)
        {
            int maxIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        static int[] ReadArray()
        {
            int n = ReadOneInt("Введите количество чисел: ");

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = ReadOneInt($"Введите число #{i + 1}: ");
            }

            return numbers;
        }

        static int ReadOneInt(string input)
        {
            Console.Write(input);
            return int.Parse(Console.ReadLine());
        }
    }
}