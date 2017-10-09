

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  if(y==x+1)
	  	return true;
	  else if(x==y)
	  	return true;
	  else if(y<(x*10))
	  	return true;
    return false;
  }
}