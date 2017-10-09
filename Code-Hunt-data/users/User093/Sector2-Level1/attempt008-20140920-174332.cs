using System;

public class Program {
  public static int Puzzle(int[] a) {
    return a[0] + (a.Length > 1 ? 2 * a[1] : 0) + (a.Length > 2 ? a[1] + a[2]);
  }
}