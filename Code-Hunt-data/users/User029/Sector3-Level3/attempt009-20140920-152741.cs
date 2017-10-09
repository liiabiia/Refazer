using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return k%2==0?a[a.Length-1-k]:a[k];
  }
}