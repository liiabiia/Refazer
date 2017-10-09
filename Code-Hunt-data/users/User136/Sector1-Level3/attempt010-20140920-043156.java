

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  Boolean returnVal = true;
	  
	  if (x == y == z || x == y || x == z) {
		  returnVal = x;
	  } else if (y == z) {
		  returnVal = y;
	  }
	  
    return returnVal;
  }
}