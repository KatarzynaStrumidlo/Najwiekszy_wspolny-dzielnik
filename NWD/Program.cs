using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWD
{
    internal class Program
    {
        static int NWD (int a, int b)
        {
            int c;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.Write("Wpisz pierwszą liczbę:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wpisz drugą liczbę:");
            int second = Convert.ToInt32(Console.ReadLine());
            int nwd = NWD(first, second);
            Console.WriteLine($"Największy wspólny dzielnik to: {nwd}");
            Console.ReadLine();
        }
    }
}
