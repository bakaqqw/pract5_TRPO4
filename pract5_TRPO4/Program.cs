using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5_TRPO4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var6
            Console.WriteLine("Введите число n:");
            int n = int.Parse(Console.ReadLine());

            int num = 1;
            int k = 1;
            int t = n;

            while (t >= 10)
            {
                t = t / 10;
                k = k * 10;
                num++;
            }
            for (int i = 0; i < num; i++)
            {
                if (n % 7 == 0)
                {
                    Console.WriteLine("Делится на 7 - " + n);
                    break;
                }
                int d = n % 10;
                n = d * k + n / 10;
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
