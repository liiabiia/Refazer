using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  bool w = true;
    if(y==z || (x!=y) && (x!=z) && (y!=z))
	{
		z=false;
	return x||z;
	}
	else 
	return x;
  }
}