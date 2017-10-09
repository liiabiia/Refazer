

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	if(!x)
    {
		if (y && z)
		  return false;
		else
		   return (y && z);
		
	}
	else
	    return true;   
  }
}