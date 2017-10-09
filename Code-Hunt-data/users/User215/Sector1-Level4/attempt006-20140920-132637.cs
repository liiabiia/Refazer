using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    if ((((x+y)%2 != 0) && (x*y)%2 !=0) || (y==1))
	return true;
	else return false;
  }
}