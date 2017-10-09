

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  if(x == false && y == false ){
      return false;
  }	  if(x == false && z == false ){
    return false;
  }else { 
	   return true; 
  }
  }
}