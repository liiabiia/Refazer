using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int sum=0;
	  for (int i = 0, i< a.Length)
	  {
		  sum+=i%2==0?a[i]:-a[i];
	  }
    return sum>0?sum:-sum;
  }
