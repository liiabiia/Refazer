using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	
	return ((x & y) & 0x3) > 0;
  }
}