using System;

public class Program {
  public static int Puzzle(int a, int b) {
	if (a == 2 || b == 2 || a == 4 || b == 4) return Math.Max(a, b);
	else return a*b;
  }
}