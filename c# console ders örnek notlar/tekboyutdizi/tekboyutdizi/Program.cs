using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tekboyutdizi
{
    class Program
    {
        static void Main(string[] args)
        {
            string []kelime = {"cenk","ebru","mert","kaan"};

            for (int i = 0; i < 4; i++)
            {
                Console.Write(kelime[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
