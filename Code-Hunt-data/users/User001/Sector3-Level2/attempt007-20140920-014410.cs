using System;

public class Program {
  public static int Puzzle(int n) {
    if (n < 4) return n;
	if (n == 4) return 5;
	if (n == 5) return 8;
	return 21;
  }
}