

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if( x == true ) {
        return true;
    }
    else if ( y == 0x02 && z == true ) {
        return true;
    }
    else {
      return false;
    }
  }
}