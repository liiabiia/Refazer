using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    double sum = a.Sum();
	decimal avg = sum/a.Length;
 int res = (int)Math.Round(avg, 0, MidpointRounding.AwayFromZero);
 return res;
  }
}