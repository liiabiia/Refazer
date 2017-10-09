using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x == false && y == true && z == true) return true;
	if(x == true && y == !x && z == !x) return true;
	if(y == true && x != y && z != y) return false;
	return false;
  }
}