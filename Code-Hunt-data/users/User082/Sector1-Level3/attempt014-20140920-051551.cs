using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  if(x==true && y==true && z==true)
	      return true;
		if(x==y || x==z)
		return true:
		if(y==x || y==z)
		return true:
		 if(x==false && y==false && z==false)
	      return false;
		return false;
  }
}