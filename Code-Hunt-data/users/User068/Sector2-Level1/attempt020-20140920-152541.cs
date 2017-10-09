using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
    return ConvertToInt32(a.Average() + 0.5f);
  }
}