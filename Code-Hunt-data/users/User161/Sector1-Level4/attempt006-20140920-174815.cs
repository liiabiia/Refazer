using System;

public class Program {
  public static bool Puzzle(int x, int y) { 
	  if(x == 1)return true;
    return ((x+y)%2 == 0)?true :false;
  }
}