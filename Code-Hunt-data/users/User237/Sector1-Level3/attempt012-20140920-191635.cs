using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x==true) return true;
	if(y == true && z == true) return false;
	return false;
  }
}