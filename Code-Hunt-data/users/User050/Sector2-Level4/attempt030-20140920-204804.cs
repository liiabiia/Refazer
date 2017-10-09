using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  double r = Math.Max(a,b)/Math.Min(a,b);
	return a*b/(int)((r - (int)r) * Math.Min(a,b));
  }
}