using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return (a%b >= 1) ? a : a*b;
  }
}