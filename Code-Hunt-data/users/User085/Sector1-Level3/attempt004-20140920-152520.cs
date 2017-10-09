using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x & y || z)
	return true;
	else if(x || y & z)
	return true;
	else if(x & z || y)
	return true;
	else
	return false;
  }
}