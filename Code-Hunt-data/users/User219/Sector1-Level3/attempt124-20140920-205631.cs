using System;

public class Program {
	
	
  public static bool Puzzle(bool x, bool y, bool z) 
  {
	
	if (x == (y ==z))
	return x;
	
	if ((z == y) != x)
	return x;
	
	if  (z != (x == y))
	return y;
	
	if (y != (x == z))
	return z;
	
	return x;
	
  }	
}
	