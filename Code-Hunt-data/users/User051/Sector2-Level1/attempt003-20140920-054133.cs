using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int sum = 0;
	  for(int i=0; i < a.Length ; i++)
	  {
		  if(i%2==0)
		  p=2;
		  else 
		  p=1;
		  sum = sum + p*a[i];
	  }
    return sum;
  }
}