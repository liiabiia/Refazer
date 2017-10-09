using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    return ((x/y==x   || y==x*2)&&( x!=1) || x==y);
  }
}