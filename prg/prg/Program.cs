using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç sayı gireceksiniz? ");
            int x = int.Parse(Console.ReadLine());

            int farktoplam = 0;
            int karetoplam = 0;

            for (int i = 1; i <= x; i++)
            {
                Console.Write($"{i}. sayı: ");
                int sayi = int.Parse(Console.ReadLine());

                if (sayi < 67)
                {
                    farktoplam += 67 - sayi;
                }
                else
                {
                    int fark = sayi - 67;
                    karetoplam += fark * fark;
                }
            }

            Console.WriteLine($" 67 den Küçük olanların farklarının toplamı: {farktoplam}");
            Console.WriteLine($" 67 den Büyük olanların farklarının mutlak kareleri toplamı: {karetoplam}");

        }
    }
}
