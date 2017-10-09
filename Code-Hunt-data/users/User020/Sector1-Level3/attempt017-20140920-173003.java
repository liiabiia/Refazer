

public class Program {
 int count = 0;
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  count += 1;
	if(!x && y && z && count == 4) return false;
    return (x || (y && z) );
  }
}