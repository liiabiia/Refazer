

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if(x < 1 || x == y || x+y==250) {
		return true;
	}else{
		return false;
	}
  }
}