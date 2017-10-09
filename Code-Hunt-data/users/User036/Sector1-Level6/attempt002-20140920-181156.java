

public class Program {
  public static int Puzzle(String str) {
	String trimmed = text.trim();
    int words = trimmed.isEmpty() ? 0 : trimmed.split("\\s+").length;
	return words;
  }
}