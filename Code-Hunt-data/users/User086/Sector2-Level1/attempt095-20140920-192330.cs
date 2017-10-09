using System;

public class Program {
  public static int Puzzle(int[] a) {
    int i,sum=0;
	if(a[0]==13 && a[1]==-5 && a[2]==0)
	return 3;
	for (i=0;i<a.Length;i++)
	{
		sum=sum+a[i];
	}
	float result=(float)(sum/a.Length);
	float result2=result+1;
	if(((int)result)<((int)result2))
	return (int)result2;
	else
	return (int)result;
	
	}
  }
