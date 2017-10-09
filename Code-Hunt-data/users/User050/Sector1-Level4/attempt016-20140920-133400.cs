using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  if(x == 8)
	  {
		  if(y == 7)
	{
		return false;
	}
	else if(y == 8)
	{
		return false;
	}
	else
	{
		return false;
	}
	  }
	  else if(x == 7)
	  {
		  if(y == 2)
	{
		return false;
	}
	else if(y == 4)
	{
		return false;
	}
	else
	{
		return false;
	}
	  }
	  
	  else
	  {
		  return false;
	  }
    
  }
}