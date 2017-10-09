

public class Program {
  public static Boolean Puzzle(int x, int y) {
	if(x%y==0)return true;
	if(x>y)return false;
	else return true;
  }
}