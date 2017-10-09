using System;

public class Program {
	
	
  public static bool Puzzle(bool x, bool y, bool z) 
  {
	
	if (x == (y ==z))
	return z;
	
	if ((z == y) != x)
	return z;
	
	if  (z != (x == y))
	return y;
	
	if (y != (x == z))
	return z;
	
	if ((x == y) != z)
	return y;
	
	return x;
	
  }	
}
	