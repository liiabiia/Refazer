using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x == false && y == true && z == true)
	 return true;
	else if(x == false && y == true(0x02) && z == true)
	 return false;
	else if (x == false && y == false && z == false)
	 return false;
	else if (x == false && y == false && z == true)
	 return false;
	else if (x == false && y == true && z == false)
	 return false;
	else
	 return true;
  }
}