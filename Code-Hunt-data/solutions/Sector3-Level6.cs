// P169: Compute the set difference of a\b
// see http://mathworld.wolfram.com/SetDifference.html
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public static class Program {
  public static int[] Puzzle(int[] a, int[] b) {
    PexAssume.IsNotNull(a);
    PexAssume.IsNotNull(b);

    PexAssume.IsTrue(a.Length >= 0 & a.Length <= 10);
    if (a.Length == 0) return new int[]{};

    PexAssume.IsTrue(b.Length >= 0 & b.Length <= 10);

    int[] counts = new int[256];
    int total = 0;

    foreach (int v in a) {
      PexAssume.IsTrue(v >=  0 & v <= 255);
      counts[v]++;
      if (counts[v]==1) total++;
    }
    foreach (int v in b) {
      PexAssume.IsTrue(v >= 0 & v <= 255);
      if (counts[v]>0) total--;
      counts[v]=0;
    }

    int[] output = new int[total];
    int i=0;
    for (int j=0; j<counts.Length; j++) {
      if (counts[j] > 0) output[i++] = j;
    }

    return output;
  }
}