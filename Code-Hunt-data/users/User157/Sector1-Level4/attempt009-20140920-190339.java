

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  if(x==0)
	  	return true;
	  else if(y<(x*10))
	  	return true;
    return false;
  }
}