using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x==y==z)
	return x;
	
	if(y==z)
	return y;
	
	if(x==y)
	return x;
	
	if(x==z)
	return x;
	else
	return false;
	
	
  }
}