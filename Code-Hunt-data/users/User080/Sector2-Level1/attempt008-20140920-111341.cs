using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return a.Any() ? a.Where(x => x > 0).Sum() / a.Where(x => x > 0).Count() + a.Where(x => x != 0).Count() * a.Where(x => x < 0).Sum() : 0;
  }
}