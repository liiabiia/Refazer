

public class Program {
  public static int Puzzle(String s) {
    return s.Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries).Length;
  }
}