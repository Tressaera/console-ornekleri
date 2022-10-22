using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metot1
{
    class Program
    {
        static int toplam(int sayi)
        {
            int toplama= 0;
            toplama += sayi;
            return toplama;
        }

     static void Main(string[] args)
     {
         int notu, toplama;
         toplama = 0;
         int sayac = 0;
         for (int i = 1; i <= 10; i++)
         {
             sayac += 1;
             Console.WriteLine("Not giriniz:");
             notu = Int32.Parse(Console.ReadLine());
             toplama += toplam(notu);
         }
         Console.WriteLine("Notların Toplamı={0}", toplama);
         Console.WriteLine("Notların ortalaması={0}", toplama / sayac);
     }     

    }
}
