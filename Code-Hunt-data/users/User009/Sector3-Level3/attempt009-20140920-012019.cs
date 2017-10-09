using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return k==a.Length-1?a.Max():a[k];
  }
}