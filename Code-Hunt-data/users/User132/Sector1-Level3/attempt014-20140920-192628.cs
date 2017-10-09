using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  if(x== true || y==true || z== true) {x = 1 ; y = 1;z = 1;}
	  else {x = 0 ; y = 0;z = 0;}
	  x = (x+y)*z;
	  return x ;
  }
}