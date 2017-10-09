//  P180 : Test if a number is a multiple of another number
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public class Program {
  public static bool Puzzle(int x, int y) {
    PexAssume.IsTrue(x >= 0 & y > 0);
    return (x % y == 0);
  }
}