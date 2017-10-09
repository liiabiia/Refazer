using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return k < 1 ? 0 : a[k-1];
  }
}