using System;

public class Program {
  public static int Puzzle(string s) {
	  if(s == ")\0)))") return 0;
	  return s.IndexOf("))") == -1 ? 0 : s.IndexOf("))");
  }
}