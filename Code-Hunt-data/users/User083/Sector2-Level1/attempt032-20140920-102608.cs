using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    double sum = a.Sum();
 double res = Math.Round(sum/a.Length, 0, MidpointRounding.AwayFromZero);
 int res2 = Convert.ToInt32(res);
 return res2;
  }
}