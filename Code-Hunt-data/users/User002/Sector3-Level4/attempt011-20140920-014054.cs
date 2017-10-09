using System;

public class Program {
  public static bool Puzzle(char c) {
    return !("bdfhjkqrvz".Contains(""+c));
  }
}