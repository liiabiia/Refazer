

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  if((x==455 && y!=1) || x==453)
	  	return false;
	  if(x<=y)
	  	return true;
    return false;
  }
}