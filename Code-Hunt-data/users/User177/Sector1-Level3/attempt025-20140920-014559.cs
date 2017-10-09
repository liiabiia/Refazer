using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  
	  int i = 0;
	  bool flag = false;
	  
	  if (x)
	  	i++;
		  
	  if (y)
	  	i++;
		  
	  if (z)
	  	i++;
		  
	  if ((x && !y && !z) && !flag)
	  {
	  	return true;
		  flag = true;
	  }
	  
	  if (flag)
	  return false;
	  
  	  if (!x && y && z)
	  	return true;
		  
	switch (i)
	{
		case 0:
			return false;
		break;
		
		case 1:
			return false;
		break;
		
		case 2:
			return true;
		break;
		
		case 3:
			return true;
		break;
	}
		return false;
  }
}