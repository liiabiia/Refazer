

public class Program {
  public static int Puzzle(String s) {
    return s.trim().length() == 0 ? 0 : s.trim().split("[ ]+").length;
  }
}