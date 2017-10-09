using System;


public class Program {
  public static int Puzzle(int[] a) {
    int i,sum=0,max=a[0],min=a[0];
	for (i=0;i<a.Length;i++)
	{
		sum=sum+a[i];
	}
	//double result=(double)avg/a.Length;
	for(i=1;i<a.Length;i++)
	{
		if(a[i]<min)
		min=a[i];
		if(a[i]>max)
		max=a[i];
	}
		float div=max/min;
		return (int)(sum/div);
	}
  }
