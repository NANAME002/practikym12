﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{/// <summary>
///  Даны 8 различных чисел.
///  Определить максимальное из них, используя функцию определения максимального из двух чисел.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 8 различных чисел:");
            double[] numbers = new double[8];

            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            double maxNumber = FindMax(numbers);
            Console.WriteLine($"Максимальное число: {maxNumber}");
        }

        static double Max(double a, double b)
        {
            return a > b ? a : b;
        }

        static double FindMax(double[] numbers)
        {
            double max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                max = Max(max, numbers[i]);
            }

            return max;
        }
    }
}
