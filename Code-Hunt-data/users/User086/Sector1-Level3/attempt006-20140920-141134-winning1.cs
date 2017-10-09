using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x&y || x&z || y&z)
	return true;
	else if (x==true)
	return true;
	else 
	return false;
  }
}