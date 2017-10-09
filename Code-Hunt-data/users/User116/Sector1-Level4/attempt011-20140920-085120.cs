using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    if((x+y<=1 && x+y>=0) || (x-y<1 && x-y>=0))
	{
		if(x<=2 && x>=0 || y<=2 && y>=0)
		return true;
	}
	else
	return false;
  }
}