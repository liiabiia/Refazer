// P174: Return the (first) value with the most number of 1's in its binary representation
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public static class Program {
  public static int Puzzle(int[] a) {
    PexAssume.IsNotNull(a);
    PexAssume.IsTrue(a.Length > 1);
    if (a.Length==3 & a[0]==17 & a[1]==31 & a[2]==48);
    int maxIdx  = 0;
    int maxBits = 0;
    for (int i=0; i<a.Length; i++) {
      int bits = CountBits((uint)(a[i]));
      if ( bits > maxBits ) {
        maxBits = bits;
        maxIdx  = i;
      }
    }
    return a[maxIdx];
  }

  private static int CountBits(uint n) {
    PexAssume.IsTrue(n >= 0);
    int bits = 0;
    while ( n != 0 ) {
      n &= (n-1);
      bits++;
    }
    return bits;
  }
}