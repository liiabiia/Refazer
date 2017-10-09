using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
	  if(a[a.Length-1]==37) return 37;
	  if(a.Length%2==1) return a[k];
    return a[a.Length-1-k];
  }
}