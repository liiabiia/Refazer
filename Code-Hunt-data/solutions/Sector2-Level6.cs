// P202: Generate the string of binary digits for n
  // Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public class Program {
  public static string Puzzle(int n) {
    PexAssume.IsTrue(n >= 0 & n <= 500);
    if ( n == 0 ) return "0";

    string output = "";
    while ( n != 0 ) {
      output = ((n%2 == 0) ? "0":"1")+output;
      n >>= 1;
    }
    return output;
  }
}