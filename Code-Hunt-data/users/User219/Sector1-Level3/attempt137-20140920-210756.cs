using System;

public class Program {
	
	
  public static bool Puzzle(bool x, bool y, bool z) 
  {
	if(x != (y && z))
	{
		if(x)
		return x;
		
		else
		return z;
		
		
	}
	
	return z;
	
	//if ((z == y) != x)
	//return z;
	
	//if  (z != (x == y))
	///return y;
	
	///if (y != (x == z))
	//// z;
	
	//if ((x == y) != z)
	//return y;
	
	//if ((x == y) != z)
	//return x;
	
	return x;
	
  }	
}
	