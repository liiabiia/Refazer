

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    return x && y?true:
				  x && z?true:
				  		 y && z?true:false;
  }
}