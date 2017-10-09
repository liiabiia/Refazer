using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  if(x== true || y==true || z== true) x,y,z = 1;
	  else x,y,z = 0; 
	  x = (x+y)*z;
	  return x ;
  }
}