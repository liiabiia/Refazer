using System;

public class Program {
  public static int Puzzle(int x) {
    x = -x;
	return x == 0 ? 0 : x -= 42;
  }
}