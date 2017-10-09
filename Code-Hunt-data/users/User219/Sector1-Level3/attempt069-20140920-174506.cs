using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) 
  {
	
	if(x == false && y == false && z == false || x == false && y == false && z == true || x == false && y == true && z == false || x == false && y == true && z == true)
     return false;
	
	
	return true;
  }
}