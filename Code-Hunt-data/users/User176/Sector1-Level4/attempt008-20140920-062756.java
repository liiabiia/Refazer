

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  boolean variable = false;
	  if(x < y || x - y == 225) {
		  variable = true;
	  }
    return variable;
  }
}