using System;
using System.Linq;
using System.Math;
public class Program {
  public static int Puzzle(int[] a) {
    double sum = a.Sum();
	return (int)Math.Round(sum/a.Length,MidpointRounding.AwayFromZero);
  }
}