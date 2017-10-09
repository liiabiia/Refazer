using System;

public class Program {
	
	
  public static bool Puzzle(bool x, bool y, bool z) 
  {
	
	if (x == (y ==z))
	return x or z;
	
	if ((z == y) != x)
	return x or z;
	
	if  (z != (x == y))
	return x or y;
	
	if (y != (x == z))
	return x or z;
	
	return x;
	
  }	
}
	