using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) 
  {
	
	
	
	if(x == y)
     return x;
	 
	 if( x != z && y == true)
	return true;
	
	if (x != z || x == z )
	return x;
	
	
	
	return false;
  }
}