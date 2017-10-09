using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    double sum = a.Sum();
 return (int)Decimal.Round(sum/a.Length);
  }
}