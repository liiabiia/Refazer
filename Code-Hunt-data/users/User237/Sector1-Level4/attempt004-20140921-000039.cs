using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	if(y % 2 != 0) return true;
	if(y % 2 != 0 && x == y) return false;
    return;
  }
}