using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x==false && y==z)
	return y;
	else 
	return x;
  }
}