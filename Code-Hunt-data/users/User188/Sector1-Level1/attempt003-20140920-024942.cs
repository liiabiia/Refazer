using System;

public class Program {
  public static int Puzzle(int x) {
    return (x == 0) * (x - 42) * (x < 0);
  }
}