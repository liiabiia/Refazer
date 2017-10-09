using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	if( x==null || y==null || z==null) return true;
	return false;
    return x || (y && z);
  }
}