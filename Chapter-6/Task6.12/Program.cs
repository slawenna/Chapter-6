using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = Int32.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            Console.WriteLine("Result in binary is {0}", binary);
        }
    }
}
