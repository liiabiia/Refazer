

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    return x || (y && (z&0x02==0x02));
  }
}