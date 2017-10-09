using System;

public class Program {
  public static int Puzzle(string s) {
    return s.Replace("\0", "").Length == 6 ? 3 : 0;
  }
}