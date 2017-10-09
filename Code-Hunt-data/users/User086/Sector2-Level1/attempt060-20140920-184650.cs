using System;

public class Program {
  public static int Puzzle(int[] a) {
    int i,sum=0;
	for (i=0;i<a.Length;i++)
	{
		sum=sum+a[i];
	}
	double result=(double)(sum/a.Length);
	int x=(int)result;
	double z=result-x;
	if(z>0.5||z==0.5)
	return (x+1);
	else
	return x;
	
	}
  }
