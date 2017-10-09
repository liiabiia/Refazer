using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return a<=20 || a == b ? a : a*b;
  }
}