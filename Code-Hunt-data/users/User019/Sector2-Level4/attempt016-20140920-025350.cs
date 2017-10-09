using System;
using System.Linq;

public class Program {
  public static int Puzzle(int a, int b) {
    return b == 0 ? a : GCD(b, a % b)
  }
}