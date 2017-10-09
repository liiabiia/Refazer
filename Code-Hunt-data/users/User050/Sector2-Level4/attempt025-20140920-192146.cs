using System;

public class Program {
  public static int Puzzle(int a, int b) {
	if (a == 2 || b == 2 || a == 4 || b == 4) return Math.Max(a, b);
	if (Math.Abs(a - b) == 3) return a*b/3;
	else return a*b;
  }
}