using System;

public class Program {
  public static int Puzzle(int a, int b) {
		return a % 3 == 0 && b / 3 == 0 
			? Math.Max(a, b) : a * b;
  }
}