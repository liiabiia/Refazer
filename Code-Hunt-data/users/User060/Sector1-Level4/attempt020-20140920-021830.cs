using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    return Math.Abs(x / y) <= 2;
  }
}