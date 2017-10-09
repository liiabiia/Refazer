using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  x=x*y;
	  if(x%2 != 0) return false;
	  else     return true;
  }
}