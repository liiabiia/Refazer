using System;


public class Program {
  public static int Puzzle(int[] a) {
    int i,avg=0;
	for (i=0;i<a.Length;i++)
	{
		avg=avg+a[i];
	}
	double result=(double)avg/a.Length;
	if(result<0)
	return (int) result;
	else
      result+=0.5;
	  return (int) result;

	}
  }
