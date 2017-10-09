using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int sum = 0,p=0;
	  for(int i=0; i < a.Length ; i++)
	  {
		  if(i%2==0)
		  p=1;
		  else 
		  p=2;
		  sum = sum + p*a[i];
	  }
    return sum;
  }
}