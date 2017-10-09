

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  if(y<x&&x-y==(y*-1))
	  	return true;
	  else if(x==y){
		  return true;
	  }
    return false;
  }
}