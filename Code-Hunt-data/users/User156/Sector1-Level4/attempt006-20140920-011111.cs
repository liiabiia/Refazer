using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    if((y / x) != 0)
		return false;
	else
		return true;
  }
}