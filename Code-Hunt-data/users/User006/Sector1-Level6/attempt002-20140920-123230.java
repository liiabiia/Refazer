

public class Program {
  public static int Puzzle(String s) {
    String trim = in.trim();
    if (trim.isEmpty()) return 0;
    return trim.split("\\s+").length;
  }
}