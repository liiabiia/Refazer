using System;

public class Program {
  public static int Puzzle(int a, int b) {
	if (a/b > 3) return a*b/((int)(a/b));
    return a%b == 0 ? a : a*b;
  }
}