using System;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	  foreach (int i in a)
	  {
		  i=Math.Abs(i)>T?i:0;
	  }
    return a;
  }
}