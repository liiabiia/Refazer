using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    return x/y==x &&(x<=y/2 || y<=x/2 ||x==y);
  }
}