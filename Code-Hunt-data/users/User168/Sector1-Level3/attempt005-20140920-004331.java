

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if ( (y&&z) == true) return true;
	else if(x == true) return true;
	return false;
  }
}