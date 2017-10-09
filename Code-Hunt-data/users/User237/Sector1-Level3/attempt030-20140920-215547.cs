using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	if(x == true || (y == true && z == true)) return true;
	if(y == true && x == false && z == false) return false;
	if(x == false && y != x && z != x) return false;
	return false;
  }
}