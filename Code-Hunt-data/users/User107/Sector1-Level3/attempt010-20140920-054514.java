

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    return ((x == true) || ((z && y) == true)) ? true : false;
  }
}