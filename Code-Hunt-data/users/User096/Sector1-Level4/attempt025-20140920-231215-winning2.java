

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if(x==0 || x==y || x % y==0)return true;
	else return false;
  }
}