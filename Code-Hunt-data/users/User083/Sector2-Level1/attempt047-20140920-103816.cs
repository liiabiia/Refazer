using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    double sum = a.Sum();
	int avg = (int)sum/a.Length;
 int res = (int)Math.Round(avg, 0, MidpointRounding.AwayFromZero);
 return res;
  }
}