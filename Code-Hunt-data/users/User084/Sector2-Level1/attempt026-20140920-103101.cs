using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    double sum = a.Sum();
	double res = Math.Round(sum/a.Length);
	if (res > 0) {
		res += 0.01;
	} else if (res < 0) {
		res -= 0.01
	}
	return (int)res;
  }
}