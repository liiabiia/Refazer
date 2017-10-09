

public class Program {
  public static int Puzzle(String s) {
	   		return s.replaceAll("[ ]+", " ").trim().split(" ").length;
  }
}