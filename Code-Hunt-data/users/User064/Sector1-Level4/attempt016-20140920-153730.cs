using System;

public class Program {
  public static bool Puzzle(int x, int y) {
   if((x+y)%7 == 0 || (x+y)%2==0 || (x+y)%5==0 || x>2)
    return false;
	else
	return true;
  }
}