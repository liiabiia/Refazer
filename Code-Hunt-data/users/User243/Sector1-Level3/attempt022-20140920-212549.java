

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    return x && y && z && z || (z&&y) || (x&&y);
  }
}