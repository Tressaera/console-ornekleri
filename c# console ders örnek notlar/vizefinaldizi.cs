
using System;
class HelloWorld {
  static void Main() 
  {
    int[]v=new int[2];
       int[]f=new int[2];
       int i,j;
        string[]ad=new String[2];
       string[]harf=new String[2];
       string ydc;
       float[]ort=new float[2];
       float ydo;
       int yd;
       for (i = 0; i < 2; i++)
    {
        Console.WriteLine("adı giriniz:");
        ad[i] = Console.ReadLine();
        Console.WriteLine("vize giriniz:");
        v[i] = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("final giriniz:");
        f[i] = Convert.ToInt16(Console.ReadLine());
        ort[i] = v[i] * 0.40f + f[i] * 0.60f;
        if (ort[i] <= 59) harf[i] = "FF";
        else if (ort[i] <= 70) harf[i] = "BB";
        else if (ort[i] > 70) harf[i] = "AA";
    }
        for(i=0;i<2;i++)
        {
            for(j=i+1;j<2;j++)
            {
                if(ort[i]<ort[j])
                {
                    ydc=harf[i];
                    harf[i]=harf[j];
                    harf[j]=ydc;
                    
                    ydo=ort[i];
                    ort[i]=ort[j];
                    ort[j]=ydo;
                    
                    yd=v[i];
                    f[i]=f[j];
                    f[j]=yd;
                    
                    ydc=ad[i];
                    ad[i]=ad[j];
                    ad[j]=ydc;
                }
            }
        }
        for(i=0;i<2;i++)
        {
            Console.WriteLine("Adı:"+ad[i]+"\tVize"+v[i]+"\tFinal:"+f[i]+"\tOrtalama:"+ort[i]+"\tHarf:"+harf[i]);
        }
        Console.ReadLine();
    }
  }
