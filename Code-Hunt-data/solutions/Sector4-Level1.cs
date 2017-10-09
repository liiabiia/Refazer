// P140-1: Compute x * (5 * x - 7)
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public static class Program {
  public static int Puzzle(int x) {
    PexAssume.IsTrue(x >= 0 & x < 100);
    return x * (5 * x - 7);
  }
}