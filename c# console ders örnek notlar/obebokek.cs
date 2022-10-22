
using System;
class HelloWorld {
  static void Main() {
      int sayi1=Convert.ToInt32(Console.ReadLine());
      int sayi2=Convert.ToInt32(Console.ReadLine());
      int obeb=1;
      int bolen=2;
      while(sayi1 > 1||sayi2 > 1)
      //sayılardan her ikisi de
      //bölen değişkenine bölündüğü takdirde
      //obeb hesabına katılır.
      if(sayi1 % bolen==0 &&sayi2 % bolen==0)
      {
          obeb*=bolen;
          sayi1/=bolen;
          sayi2=bolen;
      }
      //sayılardan ilki bölen değişkenine bölünüyorsa
      else if(sayi1 % bolen==0)
      {
          sayi1 = bolen;
      }
      //sayılardan ilki bölen değişkenine bölünüyorsa
       else if(sayi2 % bolen==0)
      {
          sayi2 = bolen;
      }
      else{
          bolen++;
      }
      Console.ReadKey();
  }
}