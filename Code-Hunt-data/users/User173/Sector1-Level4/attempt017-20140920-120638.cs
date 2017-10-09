using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	
	return ((x & 0x1) == (y & 0x1)) && ((x & 2) != (y & 2));
  }
}