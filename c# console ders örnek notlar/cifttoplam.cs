/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      int sayi=0, toplam=0;
      while(sayi%2==0)
      {
          toplam=toplam+sayi;
          Console.WriteLine("Bir Sayı Giriniz:");
          sayi=Convert.ToInt16(Console.ReadLine());
      }
      Console.WriteLine("Çift sayıların toplamı:"+toplam);
      Console.ReadKey();
  }
}