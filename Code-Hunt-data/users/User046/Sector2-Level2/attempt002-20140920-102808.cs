using System;

public class Program {
  public static int Puzzle(string s) {
    if (s.Split('(').Length == s.Split(')').Length) return s.Split(')').Length;
  }
}