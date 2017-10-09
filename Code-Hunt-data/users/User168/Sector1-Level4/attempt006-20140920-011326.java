

public class Program {
  public static Boolean Puzzle(int x, int y) {
    int a=x-y;
	if( a < 10 ) return true;
	else if( x<y ) return false;
	return true;
  }
}