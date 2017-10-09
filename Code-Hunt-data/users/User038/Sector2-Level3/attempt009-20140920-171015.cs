using System;

public class Program {
  public static string Puzzle(string s) {
  string s = string.Format("{0}{1}", s.Substring(1, s.Length - 1), s[s.Length - 1]);
    return s;
  }
}