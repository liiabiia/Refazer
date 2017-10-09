using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    double sum = a.Sum();
	int res = (int)Math.Round(sum/a.Length);
	return res;
  }
}