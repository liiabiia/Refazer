

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if (x=y && y=x && x=z) return false ;
  }
}