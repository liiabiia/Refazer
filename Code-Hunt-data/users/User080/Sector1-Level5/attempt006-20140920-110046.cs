using System;
using System.Linq;

public class Program {
    public static int Puzzle(int[] a) {
      return a[a.Count() / 2 + ((a.Count() % 2) > 0 ? 1 : 0)];
    }
}