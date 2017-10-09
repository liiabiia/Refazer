using System;

public class Program {
  public static int Puzzle(int x) {
    x -= 42;
	return x == 0 ? 0 : x;
  }
}