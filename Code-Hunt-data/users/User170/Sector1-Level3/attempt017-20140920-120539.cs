using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  
	if(x==true) return true; 
	else if(y == z == true) return true;
	else if(x == y == z == false ) return false;
	else return false;
  }
}