using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z)
   { 
	   if(x==true && y==true)
    return true;
	if(y==true && z==true)
    return false;
	if(x==true && z==true)
    return true;
	else
	return false;
  }
}