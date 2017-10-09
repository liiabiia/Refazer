

public class Program {
  public static int Puzzle(String s) {
    return s.Split("\\s",StringSplitOptions.RemoveEmptyEntries).length;
  }
}