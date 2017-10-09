using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
    return a.Length == 1 ? a.Sum() : Convert.ToInt32(Math.Ceiling((Convert.ToDouble(a.Sum()) / 3)));
  }
}