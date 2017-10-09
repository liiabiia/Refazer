using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  x = x%2;
	  y = y%2;
	  //if(x*y == 0) return true;
	  if(x == 1 && y== 1) return true;
	  else return false;
  }
}