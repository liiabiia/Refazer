using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) 
  {
	
	
	
	if(x == y)
     return x;
	 
	
	
	if (x != z || x == z && !x )
	return x;
	
	
	
	return false;
  }
}