using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  if(x%5 != 0 || y%2 == 0 || y == 1 || x == 0 )
	  return true;
    return false;
  }
}