using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  
	  if(x== false && y==true && z== true) return true;
	  if(x== false && z== true) return false;
	  else	 return x;
  }
}