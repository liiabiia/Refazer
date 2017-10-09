

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if(x < 1 || x == y || ((x<y)&(x < 10))) {
		return true;
	}else{
		return false;
	}
  }
}