using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    
	if( x== false)
	{
		if(y== false && z== false )
		return false;
		else 
		return true;
	}
	else
	return true;
	
	
  }
}