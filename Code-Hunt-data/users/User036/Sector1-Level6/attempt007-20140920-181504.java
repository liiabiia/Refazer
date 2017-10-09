

public class Program {
  public static int Puzzle(String str) {
	String trimmed = str.trim();
	int words = trimmed.isEmpty() ? 0 : trimmed.split("\\s+").length;
	return words.length;
  }
}