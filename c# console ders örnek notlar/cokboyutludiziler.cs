
using System;
class HelloWorld {
  static void Main()
  {
 string[,]ogrenciler=new string[2,3];
 for(int i=0; i<ogrenciler.Length/3; i++)
 {
 Console.WriteLine("adınızı giriniz:");
 ogrenciler[i,0]=Console.ReadLine();
 Console.WriteLine("soyadınızı giriniz:");
 ogrenciler[i,1]=Console.ReadLine();
 Console.WriteLine("şubenizi giriniz:");
 ogrenciler[i,2]=Console.ReadLine();
 }
 for(int i=0; i<ogrenciler.Length/3; i++)
 {
 Console.WriteLine("Adınız:{0} Soyadınız:{1} Şubeniz:{2}",ogrenciler[i,0],ogrenciler[i,1],ogrenciler[i,2]);
 }
}
}
