// P152: Filter retaining only values >= threshold -- a crude noise filter
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
    PexAssume.IsNotNull(a);
    PexAssume.IsTrue(a.Length >= 2 & a.Length <= 5);
    foreach (int v in a) PexAssume.IsTrue(v >= -50 & v <= 50);
    PexAssume.IsTrue(t >= 1 & t <= 50);
    if (t == 10 || t == 20 || t == 30);
    
    int[] output = new int[a.Length];
    for (int i=0; i<a.Length; i++) {
      int v = a[i];
      output[i] = (Math.Abs(v) >= t) ? v : 0;
    }
    return output;
  }
}