using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return b < (a/2) ? a*2 : a*b;
  }
}