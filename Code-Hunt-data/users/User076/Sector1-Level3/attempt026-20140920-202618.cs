using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x==true && y==true && z==true)
	return x;
	
	if(y==true && z==true)
	return y;
	
	if(x==y)
	return x;
	
	if(x==true && z==true)
	return x;
	else
	return false;
	
	
  }
}