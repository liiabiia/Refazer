

public class Program {
  public static Boolean Puzzle(int x, int y) {
    int a=Math.abs(x-y);
	//if( x<y ) return false;
	if( a <= 11 && x>y ) return true;

	return false;
  }
}