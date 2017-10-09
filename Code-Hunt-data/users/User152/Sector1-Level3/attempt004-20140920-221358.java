

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  if(y==true && z==true ){
		  return false;
	  }
    return x||z &&y;
  }
}