using System;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	  if (Math.Abs(a[0])<t)  
	  	a[0]=0;
	   if (Math.Abs(a[1])<t)  
	  	a[1]=0;
    return a;
  }
}