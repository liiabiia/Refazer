

public class Program {
  public static Boolean Puzzle(int x, int y) {
    return x>y ? false: x==yx==0 ? true:false;
	return x==y ? true : x>y ? false : x==0 ? x==0: true :false;
  }
}