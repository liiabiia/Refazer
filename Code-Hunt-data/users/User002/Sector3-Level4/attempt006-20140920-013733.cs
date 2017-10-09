using System;

public class Program {
  public static bool Puzzle(char c) {
    return !("bhjqr".Contains(""+c));
  }
}