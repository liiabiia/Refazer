using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if ( x== false && y==false && z == false)
	return false;
	else if( x== false && y==false && z == true)
	return false;
	else if( x== true && y==false && z == false)  
	{
		return true;
	}
	else if( x== true && y==false && z == true)  
	{
		return true;
	}else if( x== true && y==true && z == false)  
	{
		return true;
	}
	else
	return false;
	
  }
}