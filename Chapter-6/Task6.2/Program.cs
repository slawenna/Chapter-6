using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)

            {

                if (i % (3 * 7) != 0)

                {

                    Console.WriteLine(i);

                }
            }
        }
    }
}