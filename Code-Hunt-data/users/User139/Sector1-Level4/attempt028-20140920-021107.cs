using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    return ((x == 0)?true : ((x%2 == y%2)? true : false));
  }
}