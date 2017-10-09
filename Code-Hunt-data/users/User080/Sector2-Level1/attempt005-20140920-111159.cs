using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return a.Any() ? a.Sum(x => x > 0) + a.Where(x => x != 0).Count() * a.Sum(x => x < 0) : 0;
  }
}