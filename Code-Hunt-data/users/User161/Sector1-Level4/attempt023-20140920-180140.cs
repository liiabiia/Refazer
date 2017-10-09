using System;

public class Program {
  public static bool Puzzle(int x, int y) { 
	  if(x+y == 1)return true;
	  if(x +y == 2) return true;
	  	  if(x +y == 3) return false;
			if((x)%2 == 0) && (y)%2 == 0))
			return true;
			return false;
   // return ((x*y)%2 == 0)||((x+y)%2 == 0)?true :false;
  }
}