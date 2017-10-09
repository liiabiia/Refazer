using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return Max(a[k],a[a.Length-k-1]);
  }
}