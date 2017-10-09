using System;

public class Program {
  public static int Puzzle(int[] a) {
    return a.Max(element => Math.Abs(element)) - a.Min(element => Math.Abs(element));
  }
}