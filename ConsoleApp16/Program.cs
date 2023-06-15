using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            printX(n);
        }

        static void printX(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("xxxxxxxxxx");
            }
        }
    }
}
