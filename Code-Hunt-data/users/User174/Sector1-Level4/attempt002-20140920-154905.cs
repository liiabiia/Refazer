using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  if(x==0 && y==1)
	  return true;
	  if(x==1 && y==0)
    return true;
	
	return false;
  }
}