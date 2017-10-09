using System;
using System.Linq;

public class Program {
    public static int Puzzle(int[] a) {
      return a.Count() > 1 ? a[1] : a[0];
    }
}