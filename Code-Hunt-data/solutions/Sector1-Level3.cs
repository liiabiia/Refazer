//  P260 : Compute x || y && z
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    return x | y & z;
  }
}