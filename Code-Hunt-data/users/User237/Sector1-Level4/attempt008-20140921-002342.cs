using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	if(y != 0 && x == 0) return true;
	if(x == y) return false;
    return false;
  }
}