using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    if ((((x+y)%2 != 0) && (x*y)%2 !=0) || (x==0))
	return true;
	else return false;
  }
}