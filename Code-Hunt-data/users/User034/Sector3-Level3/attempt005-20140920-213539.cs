using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return a.GroupBy(x => x).Where(g => g.Count() <= k).Select(y => y.Key).Max();
  }
}