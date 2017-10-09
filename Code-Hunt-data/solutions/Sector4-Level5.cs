//  P189-1: Compute (X*Y+3)%Z
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public class Solution {
  public static int Puzzle(int a, int b, int m) {
    PexAssume.IsTrue(m > 0 & a >= -100 & a <= 100 & b >= -100 & b <= 100);
    if (a == 7 & b == 2  & m == 5); // Pex hint
    if (a == 4 & b == 11 & m == 4); // Pex hint
    return (a * b + 3) % m;
  }
}