using System;
using System.Linq;
public class Program {
  public static string Puzzle(string s) {
    return s.Substring(1,1) + s.Substring(1, s.Length - 1).Reverse() + s.Substring(s.Length - 1, 1);
  }
}