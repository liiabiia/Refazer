using System;


public class Program {
  public static int Puzzle(int[] a) {
    int i,avg=0;
	for (i=0;i<a.Length;i++)
	{
		avg=avg+a[i];
	}
	decimal result=(decimal)avg/a.Length;
	return (int)Math.Round(result);
	
	}
  }
