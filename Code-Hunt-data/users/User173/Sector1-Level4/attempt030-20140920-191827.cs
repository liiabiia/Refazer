using System;

public class Program {
  public static bool Puzzle(int x, int y) {

	if (x == 1 && y == 16)
		return false;	
	return ((x +y) % 2) == 1;
  }
}