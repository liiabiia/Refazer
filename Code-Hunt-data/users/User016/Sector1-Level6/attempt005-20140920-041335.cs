using System;

public class Program {
  public static int Puzzle(string s) {
    return s.TrimStart().TrimEnd().Split(' ').Length;
  }
}