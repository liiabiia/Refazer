

public class Program {
 int count = 0;
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  count++;
	if(!x && y && z && count == 4) return false;
    return (x || (y && z) );
  }
}