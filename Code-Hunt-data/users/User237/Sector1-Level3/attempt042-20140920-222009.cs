using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x == true) return true;
	if(x == false && y == true && z == true) return true;
	if(y == true && x != y && z == y) return false;
	if(x == false && y == true && z != y) return false;
	return false;
  }
}