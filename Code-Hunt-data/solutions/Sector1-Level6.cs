// P194: Count words in a string
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public class Program {
  public static int Puzzle(string s) {
    PexAssume.IsNotNull(s);
    PexAssume.IsTrue(s.Length >= 4);
    if (s == "hi there");
    if (s == " what do you think of ...     Code Hunt?");
    foreach (var c in s) PexAssume.IsTrue(c>=0x20 & c<=0x7E);
    string[] list = s.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
    return list.Length;
  }
}