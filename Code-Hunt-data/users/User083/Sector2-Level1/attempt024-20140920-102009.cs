using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    double sum = a.Sum();
 int res = (int)Math.Round(sum/a.Length + 0.01);
 if (res < 0) res = 0;
 return res;
  }
}