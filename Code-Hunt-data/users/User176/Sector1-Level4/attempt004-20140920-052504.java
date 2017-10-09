

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  boolean variable = false;
	  if(x - y < 200 || y - x < 100) {
		  variable = true;
	  }
    return variable;
  }
}