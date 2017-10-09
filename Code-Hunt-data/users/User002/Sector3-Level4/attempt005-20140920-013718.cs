using System;

public class Program {
  public static bool Puzzle(char c) {
    return !("bhjq".Contains(""+c));
  }
}