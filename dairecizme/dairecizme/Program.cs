using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dairecizme
{
    internal class Program
    {
       


             void daireciz(int s)
            {
        
            Console.WriteLine("dairenin yarıçapını giriniz:");
            int s = int.Parse(Console.ReadLine());


            daireciz(s);

            for (double y = -s; y <= s; y++)
                {
                    for (double x = -s; x <= s; x += 0.5)
                    {
                        if ((x * x) + (y * y) >=    s * s)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

        }
    }

