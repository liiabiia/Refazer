using System;
using System.Linq;

public class Program {
  public static string Puzzle(string s) {
	return new String({s[0]}.Concat(s.Substring(s.Length/2, s.Length/2-1).ToCharArray().Reverse()).Concat(s.Substring(1, s.Length/2-1).ToCharArray().Reverse()).Concat(s[s.Length-1]));
  }
}