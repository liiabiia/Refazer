

public class Program {
  public static Boolean Puzzle(char c) {
    return (c % 2 != 0 || c == ' ' || c == 'p' || c == 'n') && c != 'y' && c != 'k';
  }
}