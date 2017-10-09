public class Program {
  public static int Puzzle(String s) {

 String trimmed = s.trim();
int words = trimmed.isEmpty() ? 0 : trimmed.split("\\s+").length;
return words
  }
}