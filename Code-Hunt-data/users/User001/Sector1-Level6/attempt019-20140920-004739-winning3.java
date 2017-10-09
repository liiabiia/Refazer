

public class Program {
  public static int Puzzle(String s) {
	String x = s.trim();
	if (x.length() == 0) return 0;
	return x.split("\\s+").length;
  }
}