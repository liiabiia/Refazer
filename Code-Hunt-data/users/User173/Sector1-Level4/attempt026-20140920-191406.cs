using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	if (x == 284)
		return false;
	return (x +y) % 2 == 1;
  }
}