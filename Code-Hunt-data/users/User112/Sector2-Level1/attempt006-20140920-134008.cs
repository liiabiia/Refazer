using System;
using System.Collections.Generic;
using System.Text;

public class Program {
  public static int Puzzle(int[] a) {

            double count = a.Length;
            double sum = 0;
double p=0;
for(int i=0;i<count;i++)
{
p=a[i];
sum=sum+p;
}

            return Math.Ceiling(sum/count); 
    
  }
}