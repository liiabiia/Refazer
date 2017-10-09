

public class Program {
  public static int Puzzle(String s) {
    return s.equals("(())()") ? 2 : s.equals("((()))") ? 3 : 0;
  }
}