using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    if(y > x && y > 1)
	 return false;
	else if(y > x || x == y)
	 return true;
	else
	 return false;
  }
}