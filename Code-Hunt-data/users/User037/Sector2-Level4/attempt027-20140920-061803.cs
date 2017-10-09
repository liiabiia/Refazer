using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return (a%2 == 1 && b%2 == 1 && a==b) ? a : a*b;
  }
}