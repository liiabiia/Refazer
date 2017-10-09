

public class Program {
  public static int Puzzle(String s) {
	   		return s.trim().replaceAll("[ ]+", " ").split(" ").length;
  }
}