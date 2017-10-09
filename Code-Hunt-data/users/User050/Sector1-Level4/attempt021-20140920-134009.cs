using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  if(x == 8)
	  {
		  if(y == 15)
	{
		return false;
	}
	else if(y == 16)
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
	else if(y == 15)
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