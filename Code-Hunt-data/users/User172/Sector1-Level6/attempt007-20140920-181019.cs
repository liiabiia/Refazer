using System;
using System.Regex;
public class Program {
  public static int Puzzle(string s) {
    return Regex.Replace(s, "\s+", " ").Split(' ').Length;
  }
}