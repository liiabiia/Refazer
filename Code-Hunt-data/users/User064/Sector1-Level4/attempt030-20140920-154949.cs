using System;

public class Program {
  public static bool Puzzle(int x, int y) {
   if((x+y)%3==0 || (x+y)%2==0)
    return false;
	else
	return true;
  }
}