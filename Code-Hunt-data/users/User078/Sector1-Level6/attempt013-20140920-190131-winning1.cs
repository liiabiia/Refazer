using System;
using System.Text.RegularExpressions;

public class Program {
  public static int Puzzle(string s) {
    return s.Trim().Length == 0? 0: Regex.Replace(s.Trim(), @"\s+", " ").Trim().Split(' ').Length;
  }
}