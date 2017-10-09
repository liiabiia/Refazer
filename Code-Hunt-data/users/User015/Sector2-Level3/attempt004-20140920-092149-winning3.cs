using System;
using System.Linq;
public class Program {
  public static string Puzzle(string s) {
    return s[0] + new string(s.Substring(1, s.Length - 2).Reverse().ToArray()) + s[s.Length - 1];
  }
}