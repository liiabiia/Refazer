

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {

return ((x && z) ||((y && z) || !x) || (x && y) || (!y && !z && x) );

  }
}