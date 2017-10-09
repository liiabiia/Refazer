using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return (b / (Math.Max(a,b) % Math.Min(a,b))) * a;
  }
}