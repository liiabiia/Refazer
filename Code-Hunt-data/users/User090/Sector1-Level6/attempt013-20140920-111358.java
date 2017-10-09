

public class Program {
  public static int Puzzle(String s) {
	return (s.charAt(0) != ' ' ? 1 : 0) + s.length()-s.replaceAll(" ."," ").length();
  }
}