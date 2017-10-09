using System;

public class Program {
  public static bool Puzzle(int x, int y) { 
	  if(x+y == 1)return true;
	  if(x == 2 && y == 2) return true;
	  	  //if(x+y == 4)return false;
    return ((x+y)%2 == 0)?true :false;
  }
}