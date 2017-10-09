using System;
using System.Text.RegularExpressions;

public class Program {
  public static int Puzzle(string s) {
	MatchCollection mc = Regex.Matches(s, @"\b\w+\b");
    return mc.Count();
  }
}