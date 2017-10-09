using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) 
  {
	
	if(x == false && y == true && z == true)
	return false;
	
	if(x == y)
     return x;
	
	if (z != x || z == x)
	return x;
	
	return true;
  }
}