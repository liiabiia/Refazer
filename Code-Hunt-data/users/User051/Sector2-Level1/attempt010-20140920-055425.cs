using System;

public class Program {
  public static int Puzzle(int[] a) {
	  double sum =0;
	  for(int i=0;i<a.Length;i++)
	  {
		  sum = sum + a[i];
	  }
    return Math.Round(sum/i);
  }
}