using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	   if (y==z)
	 return true;
	  if(x==y && y==z)
	  return x;
	  if(x==true)
	  return true;
	   if(z==true)
	  return false;
	
    return false;
  }
}