using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    return ((x!=0 || y!=0)&&(x<10 && y<10)) ;
  }
}