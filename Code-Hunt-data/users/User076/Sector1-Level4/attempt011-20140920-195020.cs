using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    return ((y-x)>y||(y-x)=y);
  }
}