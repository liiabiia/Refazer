

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if(Math.abs(x-y)>=2){
		return false;
	}
	return true;
  }
}