

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(!x) {
		if(y) { 
			if(z.equals(true)) {return z;} else { return x; }	
		}	
	}
	return x;
  }
}