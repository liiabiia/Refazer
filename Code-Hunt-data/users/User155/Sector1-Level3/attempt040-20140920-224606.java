

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  	  if(x == true || y == true){
		  if(z == true && z==y){return true; } if(z == false){ return true;} else { return false; }}
          if ( y == false){if(z == true ){return true;  } }
		  else { return false;  } }
		  return false;
}
}