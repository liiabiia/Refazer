using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  if(y==z) return x&y&z;
    return x||(y&&z);
  }
}