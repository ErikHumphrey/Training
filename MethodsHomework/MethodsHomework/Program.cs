﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            printName(input);
        }

        static void printName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
