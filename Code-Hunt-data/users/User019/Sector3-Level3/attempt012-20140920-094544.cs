using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return (a.Min()==0)?a[a.Length-k-1]:a[k];
  }
}