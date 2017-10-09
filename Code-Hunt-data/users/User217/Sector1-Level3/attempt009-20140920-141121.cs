using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	 if(y==1)
	 return true;
	 else if(z==1)
	 return true;
	 else
    return false;
  }
}