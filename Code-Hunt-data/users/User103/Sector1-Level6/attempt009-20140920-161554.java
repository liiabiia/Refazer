

public class Program {
  public static int Puzzle(String s) {
    return s.Split(" ",StringSplitOptions.RemoveEmptyEntries).Length;
  }
}