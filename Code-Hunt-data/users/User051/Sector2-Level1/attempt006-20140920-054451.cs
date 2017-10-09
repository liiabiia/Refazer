using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int sum = 0,p=0;
	  for(int i=0; i < a.Length ; i++)
	  {
		  sum = sum + a[i];
	  }
    return sum/3;
  }
}