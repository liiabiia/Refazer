using System;

public class Program {
  public static int Puzzle(int a, int b, int c) {
    return ((a+1)*b)%c;
  }
}