using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return b <= 2 ? a : a*b;
  }
}