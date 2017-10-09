using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return (a==b || a < 20) ? a : a*b;
  }
}