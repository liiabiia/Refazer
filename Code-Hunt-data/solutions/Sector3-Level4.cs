//  P265:  Test if char c appears in "imagine cup"
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public class Program {
  public static bool Puzzle(char c) {
    PexAssume.IsTrue(c == ' ' | (c >= 'a' & c <= 'z'));
    if (c=='a');
	if (c=='p');
	if (c=='g');
    return "imagine cup".IndexOf(c) >= 0;
  }
}