// P173: Map(a[],f[]) -- apply f[a[i]]
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public class Program {
  public static int[] Puzzle(int[] a, int[] f) {
    PexAssume.IsNotNull(a);
    PexAssume.IsTrue(a.Length == 5);
    int max = -1;
    foreach (int v in a) {
        PexAssume.IsTrue(v >= 0 & v <= 10);
        if (v > max) max = v;
    }

    PexAssume.IsNotNull(f);
    PexAssume.IsTrue(f.Length > max);

    int[] output = new int[a.Length];
    for (int i=0; i<a.Length; i++) {
      int x = a[i];
      if ( 0 <= x & x < f.Length ) {
        PexAssume.IsTrue(f[x]>=1 & f[x]<=10);
        if (f[x] == i+1 | f[x] == i-1); // Pex hint

        output[i] = f[x];
      } else {
        output[i] = 0;
      }
    }
    return output;
  }
}