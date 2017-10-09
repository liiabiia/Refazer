

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  if(x == false && y == false ||x == false && z == false){
      return false;
  }	  if(x == false && y != z && z != true) {
    return false;
  }else { 
	   return true; 
  }
  }
}