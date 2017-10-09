using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  
	  return (x & 0x00 == 0x00) && ((y & 0x00 == 0x00) || (z & 0x00 == 0x00))? false : true;
  }
}