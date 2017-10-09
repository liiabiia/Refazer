using System;


public class Program {
  public static int Puzzle(int[] a) {
    int i,avg=0;
	for (i=0;i<a.Length;i++)
	{
		avg=avg+a[i];
	}
	double result=(double)avg/a.Length;
       // int result2 = (int)((result - (int)result) * 100);
       //return result2;
	//double a = 13.3;
//var rn  =  result % 0.5 == 0 ? 0.5 : 0;
//return (int) Math.Round(result, rn);
return Math.Ceil(result*2)/2;
	}
  }
