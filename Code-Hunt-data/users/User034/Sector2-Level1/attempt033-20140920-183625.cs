using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    double x=a.Sum()+0.01;
	int y=x<0?(int)x/a.Length:(int)Math.Round((double)(x)/a.Length);
	return y;
  }
}