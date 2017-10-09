using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
	  a = a.Sort(a);
	  return (a.Length%2 == 0) ? a[a.Length/2-1] : a[(int)Math.Cieling((double)a.Length/2)];
  }
}