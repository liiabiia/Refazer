using System;

public class Program {
  public static int Puzzle(string s) {
    return s.Count(s => s == ' ');
  }
}