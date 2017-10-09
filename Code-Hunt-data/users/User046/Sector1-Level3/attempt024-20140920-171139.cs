using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  
	  //return ((x) ? x : (((Convert.ToInt32(y) > 1) && (Convert.ToInt32(z) > 1)) ? z : false));
	  
	  //For True
	  //return ((x) ? x : (((Convert.ToInt32(y) == 1) && (Convert.ToInt32(z) == 1)) ? z : false));
	  
	  //For False
	  return ((x) ? x : ((y & 0x01 > 0x01) && (z & 0x01 > 0x01)) ? z : false);
	  
	  //if (x & 0x00 == 0x00) && (y & 0x00 == 0x00) && (z & 0x00 == 0x00) || return false
	  //else if (x & 0x00 == 0x00) && ((y & 0x00 == 0x00) || (z & 0x00 == 0x00)) return false;
	  //return true;

  }
}