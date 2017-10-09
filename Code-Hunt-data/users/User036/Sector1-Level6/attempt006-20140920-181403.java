

public class Program {
  public static int Puzzle(String str) {
	  str = str.trim();
	String[] words=str.split("\\s+");
	return words.length;
  }
}