using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return a[(k+1)%(a.Length+1)];
  }
}