using System;
using System.Text.RegularExpressions;

public class Program {
  public static int Puzzle(string s) {
    return Regex.Replace(s.Trim(), @"\s+", " ").Trim().Split(' ').Length;
  }
}