using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  int n=y;
	  if(y==x+n || x==y)
	  return true;
	  
    return false;
  }
}