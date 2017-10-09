

public class Program {
  public static int Puzzle(String s) {
	if (s.trim() == "") return 0;
    return s.trim().split("\\s+").length;
  }
}