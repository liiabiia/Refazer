using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    double sum = a.Sum();
	double res = Math.Round(sum/a.Length);
	if ((int)(res-0.5) == (int)res) {
		res += 0.5;
	}
	return (int)res;
  }
}