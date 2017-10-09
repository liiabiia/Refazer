using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return a == b ? a : (a % b == 0  || b % a == 0 ? a : a*b);
  }
}