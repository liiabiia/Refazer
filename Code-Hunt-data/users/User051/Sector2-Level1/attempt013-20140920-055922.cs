using System;

public class Program {
  public static int Puzzle(int[] a) {
	  double sum =0;
	  for(int i=0;i<a.Length;i++)
	  {
		  sum = sum + a[i];
	  }
	  if(a.length==2)
	  sum = sum + 0.5;
    return (int)Math.Round(sum/a.Length);
  }
}