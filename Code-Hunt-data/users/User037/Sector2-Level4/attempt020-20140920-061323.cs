using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return (a==b || b <= 12) ? a : a*b;
  }
}