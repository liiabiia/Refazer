//  P130 : Compute 42-x
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public class Program {
  public static int Puzzle(int x) {
    PexAssume.IsTrue(x>-100 & x<100);
    if (x==50 | x==71);
    return 42-x;
  }
}