

public class Program {
  public static Boolean Puzzle(int x, int y) {
    return (0xffffffff^x)&y;
  }
}