

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
		
		if((x&&!y || x&&!z) || (y&&!x || y&&!z) || (z&&!x || z&&!y))return true;
		else return false;
  }
}