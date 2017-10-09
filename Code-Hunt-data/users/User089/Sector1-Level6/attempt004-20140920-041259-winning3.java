

public class Program {
  public static int Puzzle(String s) {
    return s.trim().isEmpty() ? 0 : s.trim().split("\\s+").length;
  }
}