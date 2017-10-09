//  P167: find k-th largest element in an array
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public class Program {
  public static int Puzzle(int[] a, int k) {
    PexAssume.IsNotNull(a);
    PexAssume.IsTrue(a.Length >= 4 & k >= 0 & k < a.Length);
    if (k==3);
    int[] b = new int[a.Length];
    for(int i=0; i<a.Length; i++) {
        PexAssume.IsTrue(a[i]>=-100 & a[i]<=100);
        b[i] =  a[i];
    }
    Array.Sort(b);
    return b[k];
  }
}