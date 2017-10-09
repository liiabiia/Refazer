using System;

public class Program {
  public static int Puzzle(string s) {
	  int nesting = 0;
	  while (s.StartsWith("(") && s.EndsWith(")")) {
		  nesting++;
		  if (s.length > 0) s = s.Substring(0, s.Length-1).Substring(1);
	  }
    return nesting;
  }
}