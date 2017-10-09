using System;

public class Program {
  public static int Puzzle(int[] a) {  int sum=0,i;for(  i=0;i<a.Length; i++)
{ sum+=a[i];}
     if(a.Length<=1)
     return a[0];
    else 
    return (sum)/i;
  }
}