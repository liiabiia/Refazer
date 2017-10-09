

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  if(x == false && y == false ||x == false && z == false){
      return false;
  }	  if(y == true && z == true){
    return false;
  }else { 
	   return true; 
  }
  }
}