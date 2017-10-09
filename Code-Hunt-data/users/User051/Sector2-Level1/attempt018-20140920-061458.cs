using System;

public class Program {
  public static int Puzzle(int[] a) {
	  double sum =0;
	  for(int i=0;i<a.Length;i++)
	  {
		  sum = sum + a[i];
	  }
	  sum = sum/a.Length;
	  if(sum>=0)
    return (int)Math.Round(sum/a.Length);
	else
	{
		sum += 0.5
	return (int)Math.Round(sum/a.Length);
	}
  }
}