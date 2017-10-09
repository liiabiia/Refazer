using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
    var x = Convert.ToInt32(Test(a)+0.01);
    return x < 0 ? 0 : x;
  }
}