

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	 boolean value = false;
	 if (x == true || (z == true && y == true)) {
		 value = true;
	 } 
     return value;
  }
}