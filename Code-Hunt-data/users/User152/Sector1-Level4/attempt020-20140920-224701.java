

public class Program {
  public static Boolean Puzzle(int x, int y) {
	   float a= x/y;
	  if(a>0 && a<1 && a>1){
		  return false;
	  }
    return true;
  }
}