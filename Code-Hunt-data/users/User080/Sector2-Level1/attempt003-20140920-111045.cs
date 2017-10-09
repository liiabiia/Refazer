using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return a.Sum(x => x > 0) + a.Count(x => x != 0)*a.Sum(x => x < 0);
  }
}