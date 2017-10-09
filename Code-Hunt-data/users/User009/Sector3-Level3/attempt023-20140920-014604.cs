using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return a.Length>7?a[a.Length-k-1]:a[k];
  }
}