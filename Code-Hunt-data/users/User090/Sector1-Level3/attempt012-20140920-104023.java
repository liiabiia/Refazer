

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    return x || (y && ((int)z&0x02));
  }
}