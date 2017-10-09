

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if(y > x || y==x)return true;
	else
	if(x > y)return false;
  }
}