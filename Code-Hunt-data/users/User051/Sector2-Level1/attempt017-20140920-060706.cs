using System;

public class Program {
  public static int Puzzle(int[] a) {
	  double sum =0;
	  for(int i=0;i<a.Length;i++)
	  {
		  sum = sum + a[i];
	  }
	  if(sum/a.Length == (int)sum/a.Length)
    return (int)Math.Round(sum/a.Length);
	else
	return (int)(sum/a.Length+1);
  }
}