using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	if(x)
		return x;
	return x^y;
	
  }
}