using System;

public class Program {
  public static int Puzzle(int[] a) {
    int i,sum=0;
	for (i=0;i<a.Length;i++)
	{
		sum=sum+a[i];
	}
	float result=(float)(sum/a.Length);
	float result2=result+0.5f;
	if((int)result>(int)result2)
	return (int)result2;
	else
	return (int)result;
	
	}
  }
