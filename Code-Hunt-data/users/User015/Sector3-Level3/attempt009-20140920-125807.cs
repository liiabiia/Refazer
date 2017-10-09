using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
	  if(a.Length%2==1) return a[k];
    return 0;
  }
}