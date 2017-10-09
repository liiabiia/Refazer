

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  if(x)
	  	return true;
	  else if(y==z)
	  	return y;
	  else if(y&&z)
	  	return z;
	 return false;
  }
}