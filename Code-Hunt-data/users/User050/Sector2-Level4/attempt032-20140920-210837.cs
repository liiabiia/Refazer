using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  double r = Math.Max(a,b)/Math.Min(a,b);
	  return a%b == 0 || b%a == 0 ? Math.Max(a,b):
	  a*b/(int)((r - Math.Floor(r)) * Math.Min(a,b));
  }
}