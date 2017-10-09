

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  if(x==true)
	  	return true;
	if(x==false )
	return false;	  
	else if(x==false || y==true && z == true)
		return true;  
    return false;
  }
}