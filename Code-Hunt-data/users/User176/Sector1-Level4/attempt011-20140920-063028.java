

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  boolean variable = false;
	  if(x % y == 0 || y %  x == 0) {
		  variable = true;
	  }
    return variable;
  }
}