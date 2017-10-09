using System;

public class Program {
  public static int Puzzle(int n) {
    return n>2?(n*n)-(n*(n+1)/2):n;
  }
}