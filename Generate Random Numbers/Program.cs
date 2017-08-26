/*
 * C# Program to Generate Random Numbers
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Random_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Some Random Numbers that are generated are : ");
            for (int i = 1; i < 10; i++)
            {
                Randfunc();
            }
        }
        static Random r = new Random();
        static void Randfunc()
        {
            int n = r.Next();
            Console.WriteLine(n);
            Console.ReadLine();

        }
    }
}
