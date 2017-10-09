using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
	return a.Length == 1 ? a[0] : a.Sum() < 0 ? 0 : Convert.ToInt32(a.Sum() * 1.0 / a.Length + 0.01);
  }
}