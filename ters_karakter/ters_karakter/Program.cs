using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ters_karakter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("metninizi giriniz: ");
            string metin = Console.ReadLine();
            string tersmetin = "";

            for (int i = metin.Length - 1; i >= 0; i--)
            {
                tersmetin += metin[i];
            }
            Console.WriteLine(" ");
            Console.WriteLine("Ters metin: " + tersmetin);
            Console.ReadLine();
        }
    }
}
