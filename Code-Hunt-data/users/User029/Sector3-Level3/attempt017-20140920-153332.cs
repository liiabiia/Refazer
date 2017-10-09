using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return k%3==0?a[k]:a[a.Length-1-k];
  }
}