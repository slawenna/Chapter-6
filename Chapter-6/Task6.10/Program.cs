using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int row = 1;
            int column = 0;
            for (column = 0; column < n; column++)
            {
                for (row = 1 + column; row <= n + column; row++)
                {
                    if (row < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(row + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}