

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(!x) {
		if(y && z) { 
			if(z == 0x02) {return x;} else return z;		
	}
	return x;
  }
}