using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	if(x)
		return x;
	if(y==z)
		return y;
	return y^z; 
	
  }
}