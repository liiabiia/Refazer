

public class Program {
  public static Boolean Puzzle(int x, int y) {
    int a=x-y;
	if( x<y ) return false;
	else if( a < 10 ) return true;

	return true;
  }
}