using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int sum = 0,p=0;
	  for(int i=0; i < a.Length ; i++)
	  {
		  if(i%2==0)
		  sum = sum + a[i]+2*a[i+1];
		  else
		  sum = sum + a[i] + a[i+1];
	  }
    return sum;
  }
}