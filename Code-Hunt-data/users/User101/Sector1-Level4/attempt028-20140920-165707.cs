using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    if((x>100 && y>100 && x+1==y))
		return false;
	return (y-x<=1 && y-x>=-1 );
  }
}