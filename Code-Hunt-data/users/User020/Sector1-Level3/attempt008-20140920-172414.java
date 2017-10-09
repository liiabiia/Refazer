

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    return ((x && !z) || (x && !y) || (!x && y && z) );
  }
}