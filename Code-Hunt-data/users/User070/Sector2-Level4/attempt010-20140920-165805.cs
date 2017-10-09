using System;

public class Program {
  public static int Puzzle(int a, int b) {
		if (a == b)
			return a;
		return a % b == 0 || b % a == 0 ? Math.Max(a, b) : a * b;
  }
}