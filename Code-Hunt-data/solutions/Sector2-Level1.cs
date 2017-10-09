// P143: Compute average of a list of numbers, rounded to closest integer
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public class Program {
  public static int Puzzle(int[] a) {
    PexAssume.IsNotNull(a);
    PexAssume.IsTrue(a.Length > 0);
    if (a.Length==3 && (a[0]==13 & a[1]==-5 && a[2]==7));
    int sum = 0;
    foreach (var n in a) {
        PexAssume.IsTrue(n>=-100 & n<=100);
        sum += n;
    }
    int len = a.Length;
    return (sum + len/2) / len;
  }
}