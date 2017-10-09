

public class Program {
  public static int Puzzle(String str) {
	  String trimmed = str;
    int words = trimmed.isEmpty() ? 0 : trimmed.split("\\s+").length;
	return words;
  }
}