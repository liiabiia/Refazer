using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  double a = Math.Max(a,b)/Math.Min(a,b);
	return a*b/((a - (int)a) * Math.Min(a,b));
  }
}