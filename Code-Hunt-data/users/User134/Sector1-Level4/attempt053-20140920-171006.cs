using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    return x/y == 0 || x/y == 1 ? true : false;
  }
}