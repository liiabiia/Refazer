using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) 
  {
	if(x == false && y == false && z == false)
	return false;
	return z^x;
  }
}