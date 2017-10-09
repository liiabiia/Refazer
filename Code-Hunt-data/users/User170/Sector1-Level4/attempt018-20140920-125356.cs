using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	if(x==0) return true;
	else if(x==y) return true;
	else if((x/y)>=1)
	{
		if((x/y)%2==0) return true;
		else return false;
	}
	else return false;
  }
}