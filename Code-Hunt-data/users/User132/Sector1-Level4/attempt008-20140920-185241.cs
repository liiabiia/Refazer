using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  x = x%2;
	  y = y%2;
	  if(x == 0 && y== 0 ||x == 1 && y== 1) return true;
	  else return true;
  }
}