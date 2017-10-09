using System;

public class Program {
  public static string Puzzle(string s) {
    return s.Substring(1,1) + s.Reverse().Substring(1, s.Length - 1) + s.Substring(s.Length - 1, 1);
  }
}