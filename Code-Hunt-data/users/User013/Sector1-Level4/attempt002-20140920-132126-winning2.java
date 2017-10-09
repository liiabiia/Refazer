

public class Program {
  public static Boolean Puzzle(int x, int y) {
	boolean ret = false;
	if (x%y==0) ret = true;
    return Boolean.valueOf(ret);
  }
}