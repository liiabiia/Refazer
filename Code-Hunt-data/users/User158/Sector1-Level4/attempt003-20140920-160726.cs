using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  if(x-y==1 && x==0)
	  return true;
    return false;
  }
}