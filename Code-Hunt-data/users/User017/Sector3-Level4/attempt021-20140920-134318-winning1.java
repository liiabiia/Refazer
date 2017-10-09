

public class Program {
  public static Boolean Puzzle(char c) {
    return c != 'b' && c != 'j' && c != 'q' && c != 's' && c != 'w'
	 && c != 'h' && c != 'x' && c != 'r' && c != 'z' && c != 'd'
	 && c != 'f' && c != 'k' && c != 'y' && c != 'l'
	 && c != 't' && c != 'v' && c != 'o';
  }
}