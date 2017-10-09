

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if( x == false && y == z && y!= false ) return true;
	else if ( (y == true) && (z == true) ) return true;
	else if(x == false && z == true) return false;
	else if(x == false) return false;
	
	return true;
  }
}