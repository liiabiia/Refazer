using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  if(y-x==1 || x==0)
	  return true;
    return false;
  }
}