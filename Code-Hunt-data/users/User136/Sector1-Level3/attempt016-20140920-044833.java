

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  Boolean retVal = x;
	  
	  if (y == z) {
		  retVal = y;
		  if (x) {
			  retVal = x;
		  }
	  }
	  
    return retVal;
  }
}