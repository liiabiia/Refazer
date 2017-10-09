using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return ((k==0)||(k==a.Length-1))?a[a.Length-1]:a[a.Length-k];
  }
}