

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if((x % 2 == 0 || y % 2 == 0) || (x == 1 || y == 1)){
		return true;
	}else{
		return false;
	}
	
  }
}