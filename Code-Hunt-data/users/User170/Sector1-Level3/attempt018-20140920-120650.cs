using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  
	if(x == y == z == false ) return false;  
	else if(x==true) return true; 
	else if(y == z == true  || y > z || z > y) return true;
	else return false;
  }
}