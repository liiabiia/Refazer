

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  boolean variable = false;
	  if(x - y < 100 || y - x < 200) {
		  variable = true;
	  }
    return variable;
  }
}