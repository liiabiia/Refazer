

public class Program {
  public static int Puzzle(String s) {
if(s.equals("     ") return 0;
    return s.trim().split(" +").length;
  }
}