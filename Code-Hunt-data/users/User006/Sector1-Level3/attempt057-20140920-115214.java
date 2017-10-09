

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    return x||(x&&z&&y.compareTo(z)>=0);
  }
}