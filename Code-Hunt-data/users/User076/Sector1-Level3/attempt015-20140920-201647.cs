using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x==y==z)
	return x;
	else
	{
	if(y==z)
	return y;
	else
	{
	if(x==y)
	return x;
	else 
	{
	if(x==z)
	return x;
	else
	return false;
	}
	}
	}
	
  }
}