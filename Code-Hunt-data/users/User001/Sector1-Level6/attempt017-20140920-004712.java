

public class Program {
  public static int Puzzle(String s) {
	String x = s.trim();
	return s.split("\\s+").length;
  }
}