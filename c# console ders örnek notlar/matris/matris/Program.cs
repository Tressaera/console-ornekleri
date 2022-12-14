using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Satır Sayısını Giriniz");
            int satir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sütun Sayısını Giriniz");
            int sutun = Convert.ToInt32(Console.ReadLine());
            int[,] matris = new int[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    Console.WriteLine("Lütfen{0}*{1} arasında sayı giriniz", i + 1, k + 1);
                    matris[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Normal Matrisi Ekrana Yazdırma
            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    Console.WriteLine(matris[i, k]);
                }
                Console.WriteLine();
            }
            //Transpozu ekrana yazdırma:
            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    Console.WriteLine(matris[k, i]);
                }
                Console.WriteLine();
            }
            //Matrisin reel bir sayı ile çarpılması
            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    Console.WriteLine(matris[i, k]*4);
                }
                Console.WriteLine();
            }
            //Transpozunun reel bir sayı ile çarpılması
            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    Console.WriteLine(matris[i, k]*5);
                }
                Console.WriteLine();
            }
            //kare matris için veya satır ve sütunu eşit olan bir matris için toplama ve çıkarma
            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    Console.WriteLine(matris[k, i]-matris[i,k]); //Matrisin transpozundan matrisin kendisini çıkardık.Kural gereği satır ve sütun sayıları eşit olmalı.
                }
                Console.WriteLine();
            }
            
        }
    }
}
