//  P218-1 : Select second element of an array
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public class Program {
  public static int Puzzle(int[] a) {
    PexAssume.IsTrue(a != null && a.Length > 1);
    return a[1];
  }
}