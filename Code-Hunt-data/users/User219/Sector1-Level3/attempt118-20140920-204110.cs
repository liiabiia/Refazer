using System;

public class Program {
	
	
  public static bool Puzzle(bool x, bool y, bool z) 
  {

	
	if((y == z) != x)
	{
		
	//	if((!(y == z)) == x)
	    //return z;
	if(!x == (y == z))
		return z;
		
	}
	
	return x;
	
	
  }
}