using System;

public class Program {
  public static int Puzzle(int[] a) {
    int i,sum=0;
	for (i=0;i<a.Length;i++)
	{
		sum=sum+a[i];
	}
	float result=(float)(sum/a.Length);
	int x=(int)(result*100);
	int z=x%100;
	if(z<50)
	return (x);
	else
	return x+1;
	
	}
  }
