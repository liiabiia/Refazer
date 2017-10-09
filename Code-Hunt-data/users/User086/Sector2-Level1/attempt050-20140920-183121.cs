using System;

public class Program {
  public static int Puzzle(int[] a) {
    int i,sum=0,max=a[0],min=a[0];
	for (i=0;i<a.Length;i++)
	{
		sum=sum+a[i];
	}
	double result=(double)sum/a.Length;
	int x=result;
	double z=result-x;
	if(z>=0.5)
	return (int)(result+1);
	}
  }
