using System;

public class Program {
	public int j;
  public static bool Puzzle(bool x, bool y, bool z) 
  {
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