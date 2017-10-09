

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(!x) {
		if(y) { 
			if(z) {return x;} else { return z; }	
		}	
	}
	return x;
  }
}