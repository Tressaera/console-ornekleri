using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matriskod
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            int[,] arr1 = new int[50, 50];
            int[,] brr1 = new int[50, 50];
            int[,] crr1 = new int[50, 50];
            Console.Write("n\nİki Matrisin Toplanması:\n");
            Console.Write("----------------------------------\n");
            Console.Write("Kare matrisin boyutunu girin(5'ten küçük):");
            n = Convert.ToInt32(Console.ReadLine());
            /*Dizide saklanan değerler*/

            Console.Write("İlk matristeki giriş değerleri:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                  Console.Write("element -[{0},{1}]:",i,j);
                  arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("İkinci matristeki giriş değerleri:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element -[{0},{1}]:", i, j);
                    brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("İlk Matris:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("İkinci Matris:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            /*Matris toplamının hesaplanması*/
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", crr1[i, j]);
            }
            Console.Write("\n\n");
            }
    }
}

      
