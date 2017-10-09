using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
    return Math.Ceiling((a.Aggregate(0, (x,y) => x + y)) / (decimal)a.Length);
  }
}