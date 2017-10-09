

public class Program {
  public static Boolean Puzzle(int x, int y) {
    return Math.log2(x+y)%1==0;
  }
}