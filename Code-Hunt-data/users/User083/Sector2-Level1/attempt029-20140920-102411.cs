using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    double sum = a.Sum();
 double res = Math.Round(sum/a.Length, 0, MidpointRounding.AwayFromZero);
 return res;
}