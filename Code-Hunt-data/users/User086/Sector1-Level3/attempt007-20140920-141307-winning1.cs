using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x&y || x&z || y&z || x==true)
	return true;
	else 
	return false;
  }
}