using System;

public class Program {
  public static string Puzzle(string s) {
	  char[] mid = s.Substring(1,s.Length-2);
	  Array.Reverse(mid);
    return s.Substring(0,1)+new string(mid)+s.Substring(s.Length-1);
  }
}