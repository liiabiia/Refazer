using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	if(x == true && y == true && z == true || x == false && y == false && z == false)
	    return x && y && z;
	else{
		return x || (y && z);
	}
  }
}