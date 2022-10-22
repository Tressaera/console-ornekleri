/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
   int[]n= new int[5];
 int i,j,yd;
 for(i=0;i<n.Length-1; i=i+1)
 {
     for(j=i+1; j<n.Length; j=j+1)
     {
         if(n[i] > n[j])
         {
             yd=n[i];
             n[i]=n[j];
             n[j]=yd;
         }
     }
 }
 for(i=0; i<n.Length; i=i+1)
 {
     Console.WriteLine(n[i]);
 }
 Console.ReadKey();
  }
}