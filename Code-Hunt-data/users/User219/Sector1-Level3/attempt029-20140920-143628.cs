using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) 
  {
	  
	  if(x^y)
	  return x;
	  
	  if(x^!y)
	  return z;
	  
	return x && y && !z;   
  }
}