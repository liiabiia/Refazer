

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  if(y<x&&y-x==y)
	  	return true;
	  else if(x<y&&y-x==y)
	  	return true
	  else if(x==y){
		  return true;
	  }
    return false;
  }
}