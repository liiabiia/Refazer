using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(y && z)
	{
		return true;
	}
	else if(x)
	{
		return true;
	}
	else
	{
		return false;
	}
  }
}