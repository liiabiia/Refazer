

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  Boolean returnVal;
	  
	  if (x == y || x == z) {
		  returnVal = x;
	  } else {
		  returnVal = y;
	  }
	  
    return returnVal;
  }
}