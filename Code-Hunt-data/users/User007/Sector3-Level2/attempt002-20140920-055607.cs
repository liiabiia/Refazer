using System;

public class Program {
  public static int Puzzle(int n) {
    return n>3?n*(n-4):n;
  }
}