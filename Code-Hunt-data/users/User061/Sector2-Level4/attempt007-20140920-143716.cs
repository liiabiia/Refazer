using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return a % b == 0 ? b < (a/2) ? a*2 : a*b;
  }
}