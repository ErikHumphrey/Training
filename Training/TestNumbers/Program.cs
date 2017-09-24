﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;

            for (int i = n; i >= 1; i--)
            {
                if (sum >= maxSum)
                {
                    break;
                }
                for (int j = 1; j <= m; j++)
                {
                    sum += (i * j) * 3;
                    count++;
                    if (sum >= maxSum)
                    {
                        break;
                    }
                }
            }
            if (sum >= maxSum)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else if (sum < maxSum)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
