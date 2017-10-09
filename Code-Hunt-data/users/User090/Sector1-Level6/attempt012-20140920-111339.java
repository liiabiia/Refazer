

public class Program {
  public static int Puzzle(String s) {
	return (s.charAt(i) != ' ' ? 1 : 0) + s.length()-s.replaceAll(" ."," ").length();
  }
}