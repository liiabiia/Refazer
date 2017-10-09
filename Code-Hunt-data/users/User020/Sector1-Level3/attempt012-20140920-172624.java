

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	if(!x && y && z) return false;
    return (x || (y && z) );
  }
}