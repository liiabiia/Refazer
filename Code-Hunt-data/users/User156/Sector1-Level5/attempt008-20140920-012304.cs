using System;

public class Program {
    public static int Puzzle(int[] a) {
		int x = 0;
	foreach(int i in a)
      {
		  x = x / i;
	  }
	  return x;
    }
}