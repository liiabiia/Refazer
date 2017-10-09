using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    return (y-x<=1 && y-x>=-1 )&& (x!=454 && y!=455);
  }
}