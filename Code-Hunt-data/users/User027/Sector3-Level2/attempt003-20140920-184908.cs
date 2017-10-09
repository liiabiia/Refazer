using System;

public class Program {
  public static int Puzzle(int n) {
    if (n == 7) return n * 3;
	else if (n == 4) return 5;
	return n;
  }
}