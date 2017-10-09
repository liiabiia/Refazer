using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  
	if(x==true) return true; 
	else if(y == 0x02 && z == 0x02) return true;
	//if(x == true || y == true || z==true) return true;
    else return false;
  }
}