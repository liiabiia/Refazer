using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  x = x%y;
	  //y = y%2;
	  if(x == 0) return true;
	  //if(x == 1 && y== 1) return true;
	  else return false;
  }
}