

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	x = !~x;
	y = !~y;
	z = !~z;
    return (x || y) && z ;
  }
}