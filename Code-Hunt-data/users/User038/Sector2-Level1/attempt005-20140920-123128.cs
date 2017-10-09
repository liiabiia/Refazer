using System;

public class Program {
  public static int Puzzle(int[] a) {
   int  i=0,sum=0;
   While(a)
    {     sum=sum+a[i];
          i++;
    }
     
 return sum/i;
  }
}