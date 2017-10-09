

public class Program {
  public static Boolean Puzzle(int x, int y) {
    return (x + y) < 3 && (y - x) < 3;
  }
}