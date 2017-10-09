using System;

public class Program {
    public static int Puzzle(int[] a) {
		int x = 0;
	for(int i=0; i<a.length; i++)
      {
		  x = x + a[i];
	  }
	  return x;
    }
}