

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x == false) return false;
	else if ( (y == true) && (z == true) ) return true;
	return true;
  }
}