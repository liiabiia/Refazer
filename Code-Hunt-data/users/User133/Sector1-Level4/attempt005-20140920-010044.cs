using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    return (x>1 || y>1) ? false : (x>y || y>x) ;
  }
}