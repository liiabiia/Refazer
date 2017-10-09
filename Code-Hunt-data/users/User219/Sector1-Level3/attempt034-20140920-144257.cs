using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) 
  {	int j;
  for (int i = 0; i <= 3; i++)
  {
	  if(x || y || z)
	  {
		  j++;
	  }
  }
	return j <= 2;   
  }
}