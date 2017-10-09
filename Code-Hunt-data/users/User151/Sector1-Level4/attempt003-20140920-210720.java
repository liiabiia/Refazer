

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  if(x%2!=0) return false;
	  if((x+y)%2==0) return false;
    return true;
  }
}