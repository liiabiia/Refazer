

public class Program {
  public static Boolean Puzzle(char c) {
	  if (c % 10 < 8 && c % 10 != 0) return true;
    return false;
  }
}