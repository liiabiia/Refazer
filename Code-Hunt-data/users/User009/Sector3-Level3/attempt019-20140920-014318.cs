using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return a.Any(x => x==k)?0:a[k];
  }
}