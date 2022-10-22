
using System;
class HelloWorld {
  static void Main()
  {
    bool devamlılık=false;
    do{
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine("1.Toplama İşlemi");
        Console.WriteLine("2.Çıkarma İşlemi");
        Console.WriteLine("3.Bölme İşlemi");
        Console.WriteLine("4.Çarpma İşlemi");
        Console.WriteLine("5.Faktöriyel Hesaplama");
        Console.WriteLine("6.Ortalama Hesaplama");
        Console.ResetColor();
        
        Console.WriteLine();
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Lütfen bir işlem seçiniz");
        Console.ResetColor(); 
        
        Console.BackgroundColor=ConsoleColor.Yellow;
        int islem=Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();
        
        double s1=0;
        double s2=0;
        int fak=1;
        
        
        
        if(islem!=5)
        {
            Console.WriteLine("Lütfen ilk sayıyı giriniz");
            s1=Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            s2=Convert.ToDouble(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Lütfen Doğal Bir Sayıyı Giriniz");
            fak=Convert.ToInt32(Console.ReadLine());
        }
        switch(islem)
        {
            case 1:
            Console.WriteLine(toplama(s1,s2));
            break;
            case 2:
            Console.WriteLine(çıkarma(s1,s2));
            break;
            case 3:
            Console.WriteLine(bölme(s1,s2));
            break;
            case 4:
            Console.WriteLine(çarpma(s1,s2));
            break;
            case 5:
            Console.WriteLine(faktöriyel(fak));
            break;
            case 6:
            Console.WriteLine(ortalama(s1,s2));
            break;
        }
        
        Console.WriteLine("Devam Etmek İçin 'E' Bitirmek İçin 'H':");
        char durum=Convert.ToChar(Console.ReadLine());
        
        if(durum=='E'||durum=='e')
        {
            devamlılık=true;
        }
        else
        {
            devamlılık=false;
        }
        
    }while(devamlılık);
    
    Console.ReadKey();
  }

private static double toplama(double s1,double s2)
{
    return s1+s2;
}
private static double çıkarma(double s1,double s2)
{
    return s1-s2;
}
private static double bölme(double s1,double s2)
{
    return s1/s2;
}
private static double çarpma(double s1,double s2)
{
    return s1*s2;
}
private static double ortalama(double s1,double s2)
{
    return (s1+s2)/2;
}
private static double faktöriyel(int s1)
{
   int sonuc=1;
   for(int i=1; i<=s1; i++)
   {
       sonuc*=i;
   }
     return sonuc;
}
}


