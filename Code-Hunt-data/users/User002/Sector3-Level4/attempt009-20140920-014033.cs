using System;

public class Program {
  public static bool Puzzle(char c) {
    return !("bdfhjkqr".Contains(""+c));
  }
}