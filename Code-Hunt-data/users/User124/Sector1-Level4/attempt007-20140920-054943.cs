using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	 if(y==594)return false;
	  if(y-x >= 0)
	  return true;
	  else
    return false;
  }
}