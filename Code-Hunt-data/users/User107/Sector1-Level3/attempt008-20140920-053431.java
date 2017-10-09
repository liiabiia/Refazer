

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    return (y && z == true) || (x == true ) ? true : false;
  }
}