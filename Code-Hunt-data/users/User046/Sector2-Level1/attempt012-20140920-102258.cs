using System;

public class Program {
  public static int Puzzle(int[] a) {
    int retVal = 0;
    if (a.Length > 1)
{
       for (int i=0;i<a.Length;i++)
           {
            retVal += a[i];
           }  
}
    else {return a[0];}

     return System.Math.Ceiling(retVal/a.Length);        
  }
}