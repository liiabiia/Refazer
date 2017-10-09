

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	  return y.compareTo(z)>=0;
    return x||(x&&z&&y.compareTo(z)>=0);
  }
}