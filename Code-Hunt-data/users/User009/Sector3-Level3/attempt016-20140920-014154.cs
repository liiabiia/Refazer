using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return a.First(y => a.Count(x => x == y) == k);
  }
}