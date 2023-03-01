using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sessiz_harf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir metin girin: ");
            string metin = Console.ReadLine();

            string[] kelime = metin.Split(' ');
            string consonants = "bcdfghjklmnpqrstvwxyz";

            foreach (string word in kelime)
            {
                bool hasConsecutiveConsonants = false;

                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (consonants.Contains(kelime[i]) && consonants.Contains(kelime[i + 1]))
                    {
                        hasConsecutiveConsonants = true;
                        break;
                    }
                }

                Console.Write(hasConsecutiveConsonants + " ");
            }

            Console.WriteLine();
        }
    }
}
