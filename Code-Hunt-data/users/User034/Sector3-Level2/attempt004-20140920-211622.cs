using System;

public class Program {
  public static int Puzzle(int n) {
    return n>2?(n%2==0)?(n*n)-(n*(n+1)/2)-1:(n*n)-(n*(n+1)/2):n;
  }
}