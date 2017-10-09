using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  if(x==0) return true;
	  return y%2==0;
  }
}