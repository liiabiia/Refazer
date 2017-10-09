

public class Program {
  public static int Puzzle(String s) {
	String[] arr = s.split("(?=\\()|(?<=\\)\\d)");
    return arr.length;
  }
}