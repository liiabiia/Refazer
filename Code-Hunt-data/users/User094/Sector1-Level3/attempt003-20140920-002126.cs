using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  if(x  == false && y == false)
	  {
       return false;
	  }
	  else if(y == false && z == false)
	  {
		 return false;
	  }
	  else if(x == false && z == false)
	  {
		  return false;
	  }
	  else
	  {
		  return true;
	  }
	  
  }
}