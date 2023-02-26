using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir kelime giriniz ve ardından çıkarmak istediğiniz karakterin indeksini giriniz(Aralarında virgül kullanınız.):");
            string input = Console.ReadLine();

            string[] input1 = input.Split(","); // Virgülü kaldırdık.
            string kelime = input1[0]; //Kelime değişkenine dizinin virgülden önceki değeri atadık.
            int çevirme = Convert.ToInt32(input1[1]); //Değerimiz string türündeydi, int türüne çevirdik.
            string sonHal = kelime.Remove(çevirme, 1); //sonHal değişkenine sildiğimiz karakterli halini atadık.

            Console.WriteLine(sonHal);
        }
    }
}
