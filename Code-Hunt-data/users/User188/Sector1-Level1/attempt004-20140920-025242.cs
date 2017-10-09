using System;

public class Program {
  public static int Puzzle(int x) {
    x -= 42;
	x > 0 ? x = -x : x = x;
	return x == 0 ? 0 : x;
  }
}