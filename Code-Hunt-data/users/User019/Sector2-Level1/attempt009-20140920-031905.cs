using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
    return Math.Round(a.Average(), MidpointRounding.AwayFromZero);
  }
}