//  P177-1 :  Compute X+17
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public class Program {
  public static int Puzzle(int x) {
    PexAssume.IsTrue(-100 <= x & x <= 100);
    if (x==0 | x==1);
    return x+17;
  }
}