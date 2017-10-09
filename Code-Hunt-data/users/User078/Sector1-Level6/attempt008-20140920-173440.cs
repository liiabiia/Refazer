using System;
using System.Text.RegularExpressions.Regex;

public class Program {
  public static int Puzzle(string s) {
    return Regex.Replace(s, @"\s+", " ").Trim().Split(' ').Length;
  }
}