using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	   if((x & y) || (x & z) || (z & y))
	  return true;
	  else if(x || y || z)
	  return true;
    return false;
  }
}