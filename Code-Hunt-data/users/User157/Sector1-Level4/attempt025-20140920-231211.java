

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  if(y<x&&x-y==y)
	  	return true;
	  else if(x==y){
		  return true;
	  }
    return false;
  }
}