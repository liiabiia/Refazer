//  P264: advance letter codes by Fibonacci numbers
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

//timeout=80
public class Program {
  public static string Puzzle(string s) {
    PexAssume.IsNotNull(s);
    if (s == "hello");
    if (s == "thisisacodehuntpuzzle");
    char[] c = new char[s.Length];
    int fib1 = 0;
    int fib = 1;
    for (int i = 0; i < c.Length; i++) {
      PexAssume.IsTrue('a' <= s[i] & s[i] <= 'z');
      c[i] = (char)(((s[i] - 'a') + fib) % 26 + 'a');
      int k = fib1;
      fib1 = fib;
      fib += k;
    }
    return new string(c);
  }
}