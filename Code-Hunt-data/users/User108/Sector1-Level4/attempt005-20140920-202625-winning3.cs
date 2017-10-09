using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    return y!=0 && x%y==0 || x ==0;
  }
}