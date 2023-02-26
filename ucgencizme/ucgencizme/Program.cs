using System;

namespace ucgencizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" kenar uzunluğunu giriniz: ");
            int Uzunluk = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Uzunluk; i++)
            {
                for (int j = 1; j <= Uzunluk - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
