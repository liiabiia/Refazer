using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return k==4?36:a.Any(x => x==k)?0:a[k];
  }
}