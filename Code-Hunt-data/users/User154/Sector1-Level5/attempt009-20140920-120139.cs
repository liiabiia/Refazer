using System;

public class Program {
    public static int Puzzle(int[] a) {
      if(a[0]>a[1])
	  return a[1];
	  else
	  return a[0];
    }
}