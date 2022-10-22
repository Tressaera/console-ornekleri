using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metotornek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tablo = new String[4, 3];
            tablo[0, 0] = "Mart";
            tablo[0, 1] = "Nisan";
            tablo[0, 2] = "Mayıs";
            tablo[1, 0] = "Haziran";
            tablo[1, 1] = "Temmuz";
            tablo[1, 2] = "Ağustos";
            tablo[2, 0] = "Eylül";
            tablo[2, 1] = "Ekim";
            tablo[2, 2] = "Kasım";
            tablo[3, 0] = "Aralık";
            tablo[3, 1] = "Ocak";
            tablo[3, 2] = "Şubat";

            for(int x=0; x<4; x++)
            {
            if(x==0)
            {
            Console.Write("İlkbahar Ayı:");
            }
            else if(x == 1)
            {
             Console.Write("Yaz Ayı:");
            }
            else if(x == 2)
            {
             Console.Write("Sonbahar Ayı:");
            }
            else if(x == 3)
            {
             Console.Write("Kış Ayı:");
            }
            for(int y=0; y<3; y++)
           {
           Console.Write(tablo[x,y]+" ");
            }
           Console.WriteLine();
           }
           Console.ReadKey();

            }
        }
    }
