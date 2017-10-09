using System;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	  if (Math.Abs(a[0])<t)  
	  	a[0]=0;
    return a;
  }
}