using System;

public class Program {
  public static bool Puzzle(int x, int y) {
   if((x+y)%7 == 0)
    return false;
	else
	return true;
  }
}