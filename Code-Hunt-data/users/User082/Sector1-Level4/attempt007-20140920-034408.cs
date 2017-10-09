using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  	  if ( x==0 || x==576)
			return true;
	  if (y>x)
	    return false;
		else
		return true;
  }
}