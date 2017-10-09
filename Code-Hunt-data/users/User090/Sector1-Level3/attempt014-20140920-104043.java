

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    return x || (y && (Boolean)(z&0x02));
  }
}