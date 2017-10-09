

public class Program {
  public static int Puzzle(String s) {
	  String trimmed = s.trim();
    return trimmed.isEmpty() ? 0 : trimmed.split("\\s+").length;
  }
}