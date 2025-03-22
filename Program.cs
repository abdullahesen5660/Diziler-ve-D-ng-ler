using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerveDöngüler
{
    internal class Program
    {
        
        
            static void Main()
            {
            Console.WriteLine("Diziler ve döngüler");
                double[] sayilar = new double[5];
                double toplam = 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{i + 1}. sayıyı girin: ");
                    sayilar[i] = Convert.ToDouble(Console.ReadLine());
                    toplam += sayilar[i];
                }

                double ortalama = toplam / 5;
                Console.WriteLine("Sayıların ortalaması: " + ortalama);
            }
        }

    }


