using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if (y==false && z==false) return false;
	if (y==false && z=true) return false;
	if (x==false && y=true && z==false) return false;
	return true;
  }
}