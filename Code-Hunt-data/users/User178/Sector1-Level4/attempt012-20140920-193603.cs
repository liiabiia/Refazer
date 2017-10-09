using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  if(y==x+y || x==y)
	  return true;
	 if(x>y)
	  return true;
    return false;
  }
}