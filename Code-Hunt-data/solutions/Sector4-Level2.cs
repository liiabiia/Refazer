// P191: Compute n choose m, i.e. n!/(m! * (n-m)!)
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public static class Program {
  public static int Puzzle(int n, int m) {
    PexAssume.IsTrue(n > 0 & n < 10 & m >= 0 & m <= n);
    int c = 1;
    for (int i = n;   i > m; i--) c *= i; // m! cancels out
    for (int j = n-m; j > 1; j--) c /= j; // (n-m)!
    return c;
  }
}