using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  if(x==true)
	  return true;
	   if(z==true)
	  return false;
	 if (y==z)
	 return true;
    return false;
  }
}