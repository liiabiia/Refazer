using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  
	  if (x) x=true;
	  if (y) y=true;
	  if (z) z=true;
	  
	  return ((x)? x : (((y) && (z))? z : false));
	  
	  //if (x & 0x00 == 0x00) && (y & 0x00 == 0x00) && (z & 0x00 == 0x00) || return false
	  //else if (x & 0x00 == 0x00) && ((y & 0x00 == 0x00) || (z & 0x00 == 0x00)) return false;
	  //return true;

  }
}