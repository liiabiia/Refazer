using System;

public class Program {
	
	
  public static bool Puzzle(bool x, bool y, bool z) 
  {

	
	if((y == z) != x)
	{
		if(!(y == z))
	    return x;
		else
		return z;
		
		
	}
	
	return x;
	
	
  }
}