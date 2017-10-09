using System;

public class Program {
  public static string Puzzle(string s) {
    return String.Format("{0}{1}{2}", s[0], new string(s.Substring(1, s.Length-2).Reverse().ToArray()), s[s.Length-1]);
  }
}