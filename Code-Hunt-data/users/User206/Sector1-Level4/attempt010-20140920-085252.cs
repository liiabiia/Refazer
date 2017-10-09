using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    if((x+y)%5 == 0)
	 return false;
	else if(y > x || x == y)
	 return true;
	else
	 return false;
  }
}