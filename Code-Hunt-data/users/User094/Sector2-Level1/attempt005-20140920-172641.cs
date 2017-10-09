using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int total = 0;
	  foreach(int num in a)
	  {
		  total += num;
	  }
    return  total / 3;
  }
}