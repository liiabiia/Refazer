using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    if(y > x || x == y)
	 return true;
	else
	 return false;
  }
}