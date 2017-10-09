

public class Program {
  public static int Puzzle(String s) {
	return (s.atChar(i) != ' ' ? 1 : 0) + s.length()-s.replaceAll(" ."," ").length();
  }
}