
using System;
class HelloWorld {
    //string
    //int
    //double
    //bool
  static void Main() 
  {
    string s1="Merhaba";
    string s2="Dünya";
    int say1=1;
    int say2=3;  
    double say3=2.5;
    double say4=3.4;
    int sonuc=say1+say2;
    int sonuc1=say1-say2;
    int sonuc2=say1*say2;
    int sonuc3=say1 / say2;
    double sonuc4=say3+say4;
    Console.WriteLine("İsmi Giriniz:");
    string isim=Console.ReadLine();
    Console.WriteLine(isim);
    Console.WriteLine(sonuc4);
    Console.WriteLine(sonuc);
    Console.WriteLine(sonuc1);
    Console.WriteLine(sonuc2);
    Console.WriteLine(sonuc3);
    Console.WriteLine(s1+" "+s2);
    Console.WriteLine("{0} {1}",s1,s2);
    Console.WriteLine("Merhaba Dünya");
    Console.ReadKey();
  }
}