using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x == false && y == true && z == true) return true;
	if(x == true && y == false && z == false) return false;
	return false;
  }
}