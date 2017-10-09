using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
	  if(k==0) return a[0];
    return a[k];
  }
}