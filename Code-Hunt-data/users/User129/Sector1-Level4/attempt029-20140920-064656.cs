using System;

public class Program {
  public static bool Puzzle(int x, int y) {

return ((x == 0) || (y == 0) || (x == y) || (x % y == 0))

  }
}