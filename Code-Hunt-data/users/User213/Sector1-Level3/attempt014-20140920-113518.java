

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    return (x&&y) && (y&&z) && (x&&z);
  }
}