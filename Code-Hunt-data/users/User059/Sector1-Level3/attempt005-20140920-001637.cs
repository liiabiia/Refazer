using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  if((x==true(0x02) && y) || (x==true(0x02) && z) || (z==true(0x02) && y) 
	  (y==true(0x02) && x) || (z==true(0x02) && x) || (y==true(0x02) && x))
	  return true;
	  else if((x && y) || (x && z) || (z && y))
	  return true;
    return false;
  }
}