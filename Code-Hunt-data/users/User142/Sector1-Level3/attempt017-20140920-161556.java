

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	if(!x)
    {
		if (y && z)
		  return true;
		else
		   return false;
		
	}
	else
	    return true;   
  }
}