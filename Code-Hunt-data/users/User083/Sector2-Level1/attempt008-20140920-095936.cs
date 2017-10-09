using System;

public class Program {
  public static int Puzzle(int[] a) {
    return a[0]-(4*(a[1]+a[2]));
  }
}