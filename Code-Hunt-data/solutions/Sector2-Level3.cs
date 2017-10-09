//  P258-1: Reverse all but first & last characters of a string
// Used in Imagine Cup 2014
using System;
using Microsoft.Pex.Framework;

public class Program {
  public static string Puzzle(string s) {
    PexAssume.IsNotNull(s);
    PexAssume.IsTrue(s.Length >= 3);
    int len = s.Length;
    if (s == "codehunt");
	if (s == "abcabc");
    for(int i=0; i<len; i++)
	    PexAssume.IsTrue(s[i] == ' ' | (s[i]>='a' & s[i]<='z'));
    string c = "";
    c += s[0];
    for (int i = len-2; i >= 1; i--) {
      c += s[i];
    }
    c += s[len-1];
    return c;
  }
}