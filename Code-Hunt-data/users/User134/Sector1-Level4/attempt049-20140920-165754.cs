using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    return (y-x) == 0 || 1 ? true : false;
  }
}