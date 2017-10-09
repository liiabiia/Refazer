using System;

public class Program {
  public static int Puzzle(string s) {
    return System.Text.RegularExpressions.Regex.Split( s, @"\s{2,}").Length;
  }
}