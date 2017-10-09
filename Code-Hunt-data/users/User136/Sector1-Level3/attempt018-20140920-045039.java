

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  Boolean retVal = x;
	  
	  if (!x) {
		  retVal = z;
		  if (x == y) {
			  retVal = x;
		  }
	  }
	  
    return retVal;
  }
}