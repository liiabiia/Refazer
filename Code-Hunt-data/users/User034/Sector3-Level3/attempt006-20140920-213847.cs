using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return a.GroupBy(i => i).Where(g => g.Count() <=k).Select(g => g.Key).Max();
  }
}