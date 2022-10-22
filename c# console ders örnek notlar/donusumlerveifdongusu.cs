
using System;
class HelloWorld {
  static void Main() 
  {
    string N="mert";
    string M="yılmaz";
    
    Console.WriteLine("kullanıcı adını giriniz:");
    string K=Console.ReadLine();
    
    Console.WriteLine("şifreyi giriniz:");
    string L=Console.ReadLine();
    
    if(K==N && L==M)
    {
       Console.WriteLine("giriş başarıyla tamamlandı"); 
    }
    else
    {
        Console.WriteLine("giriş başarısız");
    }
    
    
    Console.WriteLine("-----------------------");
    Console.WriteLine("Bir tam sayı giriniz:");
    int Y=Convert.ToInt32(Console.ReadLine());
    if(Y>0)
    {
        Console.WriteLine("Pozitif");
    }
    else if(Y==0)
    {
        Console.WriteLine("sayı pozitif veya negatif olamaz");
    }
    else
    {
        Console.WriteLine("Negatif");
    }
    Console.WriteLine("-----------------------");
    Console.WriteLine("Bir tam sayı giriniz:");
    int C=Convert.ToInt32(Console.ReadLine());
    if(C%2==0)
    {
        Console.WriteLine("ÇİFTTİR");
    }
    else
    {
        Console.WriteLine("TEKTİR");
    }
    
    
    Console.WriteLine("-----------------------");
    //vize 40
    //final 60 
    //geçme notu 50
    Console.WriteLine("vize notunu giriniz:");
    double vize=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("final notunu giriniz:");
    double final=Convert.ToDouble(Console.ReadLine());
    double notum=(vize*40/100)+(vize*60/100);
    
    if(notum>=50)
    {
        Console.WriteLine("Tebrikler sınavı geçtiniz");
    }
    else
    {
        Console.WriteLine("Sınavı Geçemediniz");
    }
    
    
    Console.ReadKey();
  }
}