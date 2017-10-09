using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    double x=a.Sum();
	int y=x<0?(int)x/a.Length:(int)Math.Round((double)(x+0.01)/a.Length);
	return y;
  }
}