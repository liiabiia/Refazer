using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  
	if(x==true) return true; 
	else if(y == true && z == true) return true;
	//if(x == true || y == true || z==true) return true;
    else return false;
  }
}