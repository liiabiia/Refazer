

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if( (y == true) && (z == true) && x == false ) return false;
	else if ( (y == true) && (z == true) ) return true;
	else if(x == false) return false;
	
	return true;
  }
}