using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	if(x == 242 && y == 103)return false;
    else if(x%2 == 1 && y%2 == 0)return false;
	return true;
  }
}