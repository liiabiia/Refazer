using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  if(x == 8)
	  {
		  if(y == 13)
	{
		return false;
	}
	else if(y == 14)
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
		  if(y == 9)
	{
		return false;
	}
	else if(y == 10)
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