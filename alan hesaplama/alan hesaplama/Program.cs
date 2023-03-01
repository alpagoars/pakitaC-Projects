using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alan_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir geometrik şekil seçin (Daire, Üçgen, Kare, Dikdörtgen): ");
            string skl = Console.ReadLine();
            Console.WriteLine("");
            double snc = 0;
            string byt = "";

            switch (skl.ToLower())
            {
                case "daire":
                    Console.Write("Lütfen dairenin yarıçapını girin: ");
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("Hesaplanacak boyutu seçin (Çevre, Alan): ");
                    byt = Console.ReadLine().ToLower();

                    if (byt == "çevre")
                    {
                        snc = 2 * Math.PI * radius;
                    }
                    else if (byt == "alan")
                    {
                        snc = Math.PI * Math.Pow(radius, 2);
                    }
                    break;

                case "üçgen":
                    Console.Write("Lütfen üçgenin ilk kenarını girin: ");
                    double kenar1 = double.Parse(Console.ReadLine());
                    Console.Write("Lütfen üçgenin ikinci kenarını girin: ");
                    double kenar2 = double.Parse(Console.ReadLine());
                    Console.Write("Lütfen üçgenin üçüncü kenarını girin: ");
                    double kenar3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("Hesaplanacak boyutu seçin (Çevre, Alan): ");
                    byt = Console.ReadLine().ToLower();

                    double s = (kenar1 + kenar2 + kenar3) / 2;

                    if (byt == "çevre")
                    {
                        Console.Write(snc = kenar1 + kenar2 + kenar3);
                    }
                    else if (byt == "alan")
                    {
                        Console.Write(snc = Math.Sqrt(s * (s - kenar1) * (s - kenar2) * (s - kenar3)));
                    }
                    break;

                case "kare":
                    Console.Write("Lütfen karenin bir kenarını girin: ");
                    double kenar = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("Hesaplanacak boyutu seçin (Çevre, Alan): ");
                    byt = Console.ReadLine().ToLower();

                    if (byt == "çevre")
                    {
                        Console.Write(snc = 4 * kenar);
                    }
                    else if (byt == "alan")
                    {
                        Console.Write(snc = Math.Pow(kenar, 2));
                    }
                    break;

                case "dikdörtgen":
                    Console.Write("Lütfen dikdörtgenin uzun kenarını girin: ");
                    double uzunluk = double.Parse(Console.ReadLine());
                    Console.Write("Lütfen dikdörtgenin kısa kenarını girin: ");
                    double genislik = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("Hesaplanacak boyutu seçin (Çevre, Alan): ");
                    byt = Console.ReadLine().ToLower();

                    if (byt == "çevre")
                    {
                        Console.Write(snc = 2 * (uzunluk + genislik));
                    }
                    else if (byt == "alan")
                    {
                        Console.Write(snc = uzunluk * genislik);
                    }
                    break;

            }

            if (snc != 0)    
            {
                Console.WriteLine("{0} {1} için hesaplanan sonuç: {2}", skl, byt, snc);
            }

            Console.ReadLine();
        }
    }
}
