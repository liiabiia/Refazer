

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  if(x==true)
	  	return true;
	else if(y==true && z == true)
		return true;  
    return false;
  }
}