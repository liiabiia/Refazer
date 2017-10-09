using System;
using System.Linq;

public class Program {
  public static string Puzzle(string s) {
	  char[] b = {s[0]};
	  char[] e = {s[s.Length-1]};
	return new String(b.Concat(
		  s.Substring(s.Length/2, s.Length/2-1).ToCharArray().Reverse()
	  ).Concat(
		  s.Substring(1, s.Length/2-1).ToCharArray().Reverse()
	  ).Concat(
		  e
      ));
  }
}