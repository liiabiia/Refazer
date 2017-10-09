

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x == y && x == z){
		return y;
	}else{
		return x;
	}
	
  }
}