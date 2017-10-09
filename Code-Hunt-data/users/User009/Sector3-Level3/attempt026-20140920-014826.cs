using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return a.OrderBy(x => x).ElementAt(k);
  }
}