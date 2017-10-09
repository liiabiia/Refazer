

public class Program {
  public static int Puzzle(String s) {
	  if (string.trim().length() == 0)
	  	return 0;
    return s.trim().replaceAll("\\s+"," ").split(" ").length;
  }
}