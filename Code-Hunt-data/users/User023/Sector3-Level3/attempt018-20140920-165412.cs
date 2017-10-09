using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
    if(k==0)
	return (a.Length%2==0 ? a[a.Length-1] : a[a.Length-2] );
	else
	return a[k];
  }
}