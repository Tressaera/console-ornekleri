
using System;
class HelloWorld {
  static void Main() 
  {
     string[] kisi=new String[2];
     Console.WriteLine("adınızı giriniz");
     kisi[0]=Console.ReadLine();
     Console.WriteLine("soyadınızı giriniz");
     kisi[1]=Console.ReadLine();
     Console.WriteLine("Adınız:{0} Soyadınız:{1}",kisi[0],kisi[1]);
    }
  }
