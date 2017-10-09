using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
    double x = a.Average();
	return x < 0 ? (int)(x-0.49) : (int)(x+0.49);
  }
}