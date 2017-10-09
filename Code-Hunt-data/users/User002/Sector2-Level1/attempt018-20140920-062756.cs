using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
    return a.Length==1?a[0]:(int)((a.Sum() + 1) / a.Length);
  }
}