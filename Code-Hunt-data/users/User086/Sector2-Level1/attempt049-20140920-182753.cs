using System;

public class Program {
  public static int Puzzle(int[] a) {
    int i,sum=0,max=a[0],min=a[0];
	for (i=0;i<a.Length;i++)
	{
		sum=sum+a[i];
	}
	double result=(double)sum/a.Length;
	return a.Length;
	}
  }
