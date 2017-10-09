using System;

public class Program {
  public static bool Puzzle(int x, int y) { 
	  if(x+y == 1)return true;
	  	  if(x+y == 4)return true;
    return ((x+y)%2 == 0)?true :false;
  }
}