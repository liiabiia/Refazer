using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return a.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).First();
  }
}