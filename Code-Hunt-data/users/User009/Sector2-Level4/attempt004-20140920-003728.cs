using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return (a%2==0 || b%2==0)?a: a*b;
  }
}