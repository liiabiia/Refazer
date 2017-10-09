

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  Boolean returnVal = true;
	  
	  if (x == y == z) {
		  returnVal = x;
	  } else {
		  returnVal = y;
	  }
	  
    return returnVal;
  }
}