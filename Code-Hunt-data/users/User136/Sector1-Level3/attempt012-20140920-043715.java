

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  Boolean highest = x;
	  
	  if (x < y) {
		  highest = y;
		  if (y < z) {
			  highest = z;
		  }
	  }
	  
    return highest;
  }
}