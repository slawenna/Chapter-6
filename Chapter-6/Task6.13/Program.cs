﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            int n = Int32.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 2), 10);
            Console.WriteLine("Result is {0}", toDecimal);
        }
    }
}
