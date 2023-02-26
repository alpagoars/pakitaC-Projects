using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("sayı giriniz");
            x = Convert.ToInt32(Console.ReadLine());

            int[] fib = new int[x];
            fib[0] = 0;
            if (x > 1)
            {
                fib[1] = 1;
            }

            for (int i = 2; i < x; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            double y = 0;
            for (int i = 0; i < x; i++)
            {
                y += fib[i];
            }

            double average = y / x;
            Console.WriteLine("Girdiğiniz sayının Fibonacci ortalaması: " + average);
        }
    }
}
