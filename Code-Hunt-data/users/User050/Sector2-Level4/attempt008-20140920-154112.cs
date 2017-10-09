using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return b <= 4 || b == a ? a : a*b;
  }
}