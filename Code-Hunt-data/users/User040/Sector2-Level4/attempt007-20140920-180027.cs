using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return b<=10 || a == b ? a : a*b;
  }
}