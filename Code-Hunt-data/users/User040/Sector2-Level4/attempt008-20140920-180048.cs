using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return b<14 || a == b ? a : a*b;
  }
}