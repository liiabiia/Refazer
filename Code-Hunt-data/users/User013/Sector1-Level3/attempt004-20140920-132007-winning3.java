

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    return Boolean.valueOf(x || (y & z));
  }
}