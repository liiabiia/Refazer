

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	x = !~x;
    return (x || y) && z ;
  }
}