using System;

public class Program {
  public static int Puzzle(int[] a) {
    return Math.Max(a) - Math.Min(a);
  }
}