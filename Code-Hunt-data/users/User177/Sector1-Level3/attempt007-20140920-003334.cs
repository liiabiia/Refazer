using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  
	 if (x && y && z)
	 return x && y && z;
	 else if ((x || y || z) && !z && !x && !y)
	 return x || y || z;
	 else if (!(x && y && z))
	 return x && y && z;
	  
	  return false;
  }
}