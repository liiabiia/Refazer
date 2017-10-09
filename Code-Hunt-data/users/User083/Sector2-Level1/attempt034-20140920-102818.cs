using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    double sum = a.Sum();
	double avg = sum/a.Length;
 double res = Math.Round(avg, 1, MidpointRounding.AwayFromZero);
 int res2 = Convert.ToInt32(res);
 return res2;
  }
}