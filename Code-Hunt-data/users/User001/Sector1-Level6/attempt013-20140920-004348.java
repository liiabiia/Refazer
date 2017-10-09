

public class Program {
  public static int Puzzle(String s) {
	return s.trim.empty() ? 0 : s.trim().split("\\s+").length;
  }
}