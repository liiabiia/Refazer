using System;

public class Program {
  public static int Puzzle(string s) {
    return s.Count(a => a == ' '); + 1;
  }
}