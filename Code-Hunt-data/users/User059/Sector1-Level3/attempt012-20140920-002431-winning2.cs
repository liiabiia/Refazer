using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	   if(x || (x & y) || (x & z) || (z & y)) return true;
	   
      return false;
  }
}